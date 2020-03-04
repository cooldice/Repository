# Repository

Repository�� �����ϰ� �̸� upload / download�ϴ� ����� �����.

## Repository Server
- repository server�� upload / download���� ����Ѵ�.
- �پ��� API �� �����Ѵ�.
- Cache ������� �ӵ� UP

## Repository Client
- download
- autoupdate
- checksum 
- version�� �ٿ� ���
- version�� ��ġ ��� ���� �� ���� ���� ����

## Repository Lib
- Repository upload / download

## Requirement
- c# 
- Dotnet Core 2.1
- windows 10

## Sample
/source : source file folder
/repository : repository server folder. **���� ������ ���� �ʿ�**
/download : client download folder


## Version 1
Repository Server 
- Windows UNC ����

Repository Lib
- upload / download : single file

Repository Client
- ��ġ ���

## Version 2
Repository Lib
- upload / download : directory


## NOTE
### version 1
lib init �� instance ���� �κ� ����
class design�� �߸� �Ǿ �� singleton����
interface ������ ���ϰ� ����
upload/download�� ���ؼ� uri�� �ʿ��ѵ� �̰��� download�ϴ� �������� ���� ���� ��� �ϵ� �ڵ�
