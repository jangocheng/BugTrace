--1����insert������
if (object_id('tgr_PPM_ProblemTrace_Insert', 'tr') is not null)
    drop trigger tgr_PPM_ProblemTrace_Insert
go
create trigger tgr_PPM_ProblemTrace_Insert
on PPM_ProblemTrace
    for insert --���봥��
as
    --�������
    declare @id int, 
    @findPersonCode varchar(50), --�����
    @findPerson nvarchar(50),--���������
    @dealPersonCode varchar(50), --������
    @dealPerson nvarchar(50),--����������
    @projectManagerCode VARCHAR(50);--��Ŀ����    
    --��inserted���в�ѯ�Ѿ������¼��Ϣ
    select @id = id, @findPersonCode = FindPersonCode, 
    @projectManagerCode=ProjectManagerCode ,@dealPersonCode=DealPersonCode from inserted;
    --��ѯ����˵�����
    SELECT @findPerson=UserName FROM SYS_User WHERE UserCode=@findPersonCode;
    --��ѯ����������
    SELECT @dealPerson=UserName FROM SYS_User WHERE UserCode=@dealPersonCode;
    --������Ϣ��¼�� ����˷��������� 
    IF EXISTS(SELECT 1 FROM dbo.SYS_User WHERE UserCode=@findPersonCode) 
	AND EXISTS (SELECT 1 FROM dbo.SYS_User WHERE UserCode=@dealPersonCode)
	begin
	    insert into dbo.PPM_MessageRecord(MessageFrom,MessageTo,ProblemTraceID,MsgContent,MsgType) 
		values(@findPersonCode, @dealPersonCode, @id,'����һ��Ҫ��������������:'+@findPerson+'�������:'+CONVERT(NVARCHAR(50),@id),0); 
	END
	--������Ϣ��¼����������˲�����Ŀ��������Ҫ֪ͨ��Ŀ���� 
	IF @dealPersonCode<>@projectManagerCode
	BEGIN	
		IF EXISTS(SELECT 1 FROM dbo.SYS_User WHERE UserCode=@findPersonCode) 
		AND EXISTS (SELECT 1 FROM dbo.SYS_User WHERE UserCode=@projectManagerCode)
		begin
			insert into dbo.PPM_MessageRecord(MessageFrom,MessageTo,ProblemTraceID,MsgContent,MsgType) 
			values(@findPersonCode, @projectManagerCode, @id,'���յ�һ��֪ͨ��'+@findPerson+'��'+@dealPerson+'�����һ����������ţ�'+CONVERT(NVARCHAR(50),@id),1); 
		END
    END   
GO

--2����update������
if (object_id('tgr_PPM_ProblemTrace_update', 'tr') is not null)
    drop trigger tgr_PPM_ProblemTrace_update
go
create trigger tgr_PPM_ProblemTrace_update
on PPM_ProblemTrace
    for update
as
    declare @id INT ,
            @findPersonCode VARCHAR(50),--�����
            @findPerson NVARCHAR(50),--���������
            @oldDealPersonCode VARCHAR(50), @newDealPersonCode varchar(50),--������
            @newDealPerson NVARCHAR(50),--����������
            @oldStatus varchar(50), @newStatus varchar(50),--״̬
            @TeamLeader VARCHAR(50);--ģ�鸺����
    --����������
    SELECT @oldDealPersonCode = DealPersonCode from deleted;--����ǰ������    
    select @id=ID,@findPersonCode=FindPersonCode,@newDealPersonCode = DealPersonCode from inserted;--���º������
    --findPerson����
    SELECT @findPerson=UserName FROM dbo.SYS_User WHERE UserCode=@findPersonCode;
    IF(@oldDealPersonCode<>@newDealPersonCode)
    BEGIN		
		IF EXISTS(SELECT 1 FROM dbo.SYS_User WHERE UserCode=@findPersonCode) 
		AND EXISTS (SELECT 1 FROM dbo.SYS_User WHERE UserCode=@newDealPersonCode)
		begin
			insert into dbo.PPM_MessageRecord(MessageFrom,MessageTo,ProblemTraceID,MsgContent,MsgType) 
			values(@findPersonCode, @newDealPersonCode, @id,'����һ��Ҫ��������������:'+@findPerson+'�������:'+CONVERT(NVARCHAR(50),@id),0); 
		END
    END
    --����״̬
    SELECT @oldStatus=STATUS FROM deleted;
    SELECT @newStatus=STATUS FROM inserted;  
    --�����findPerson����
	SELECT @newDealPerson=UserName FROM dbo.SYS_User WHERE UserCode=@newDealPersonCode;
	--�����˵���ʦ��ģ�鸺���ˣ�
	SELECT @TeamLeader=TeamLeader FROM dbo.PPM_ProjectTeam WHERE TeamMember=@newDealPersonCode;  
    IF @oldStatus<>@newStatus
    BEGIN
		IF @newStatus='���ύδ���'
		BEGIN				
			--���ύ����������ģ�鸺���ˣ���ʦ��
			insert into dbo.PPM_MessageRecord(MessageFrom,MessageTo,ProblemTraceID,MsgContent,MsgType) 
			values(@newDealPersonCode, @TeamLeader, @id,'����һ��Ҫ�������񣬴�����:'+@newDealPerson+'�������:'+CONVERT(NVARCHAR(50),@id),2); 			
		END
		ELSE IF @newStatus='���'--��Ŀ�����ģ�鸺���˼�����֮����Ҫ�ύ��������Ա����
		BEGIN
			IF @findPersonCode<>@TeamLeader--��������ԱͬʱҲ����Ŀ����ģ�鸺���ˣ��������跢�Ͳ�������
			BEGIN
				insert into dbo.PPM_MessageRecord(MessageFrom,MessageTo,ProblemTraceID,MsgContent,MsgType) 
				values(@newDealPersonCode, @TeamLeader, @id,'����һ��Ҫ���Ե����񣬴�����:'+@newDealPerson+'�������:'+CONVERT(NVARCHAR(50),@id),3); 			
			END
		END
		ELSE IF @newStatus='δͨ��'
		BEGIN
			insert into dbo.PPM_MessageRecord(MessageFrom,MessageTo,ProblemTraceID,MsgContent,MsgType) 
			values(@newDealPersonCode, @TeamLeader, @id,'����һ��Ҫ��������������:'+@findPersonCode+'�������:'+CONVERT(NVARCHAR(50),@id),0); 			
		END
    END
    
    
go
