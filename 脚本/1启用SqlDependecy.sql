--1�������� MSDB ���ݿ��е� QueryNotificationService ��������Guest�û����跢��Ȩ�ޡ��������£�ע��Ҫ���ִ�Сд��
USE MSDB
GRANT SEND ON SERVICE::
[http://schemas.microsoft.com/SQL/Notifications/QueryNotificationService]
TO GUEST

--2������CLR����һ����Ϣ����������ʱ��һ������.Net����Ĵ洢����sp_DispatcherProc��ʹ��һ���������ɷ���Ϣ����˱�������Sql Server�е�CLR���ܡ����÷������£�
Use Master
Exec sp_configure 'clr enabled',1
RECONFIGURE

--3,SqlDependency �����ʹ�� Service Broker ����Ϣ���͸� QueryNotificationService����,������Ҫ���� Service Broker,����ͨ���±����鿴�Ƿ�����
select DatabasePropertyex('BugTrace','IsBrokerEnabled')--����1��ʾtrue������0��ʾfalse
--����Service Broker������£� 
use master
--ALTER AUTHORIZATION  ON DATABASE::BugTrace    TO sa;
--ALTER DATABASE BugTrace SET NEW_BROKER
--ALTER DATABASE BugTrace SET NEW_BROKER WITH ROLLBACK IMMEDIATE;
Alter Database BugTrace set enable_broker

