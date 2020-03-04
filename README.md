# Repository

Repository를 구성하고 이를 upload / download하는 기능을 만든다.

## Repository Server
- repository server는 upload / download에만 충실한다.
- 다양한 API 를 제공한다.
- Cache 기능으로 속도 UP

## Repository Client
- download
- autoupdate
- checksum 
- version별 다운 기능
- version별 설치 경로 지정 및 여러 버전 관리

## Repository Lib
- Repository upload / download

## Requirement
- c# 
- Dotnet Core 2.1
- windows 10

## Sample
/source : source file folder
/repository : repository server folder. **공유 폴더로 설정 필요**
/download : client download folder


## Version 1
Repository Server 
- Windows UNC 기준

Repository Lib
- upload / download : single file

Repository Client
- 설치 경로

## Version 2
Repository Lib
- upload / download : directory


## NOTE
### version 1
lib init 및 instance 관리 부분 소흘
class design이 잘못 되어서 다 singleton으로
interface 정리를 안하고 시작
upload/download를 위해서 uri가 필요한데 이것을 download하는 곳에서는 얻어올 곳이 없어서 하드 코딩
