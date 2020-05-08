# README

## Version

* UE 4.23

* Visual Studio 2017 with visual studio 15 2017 Win64 generator



## Reference

GameLiftClientSDK Plugin is from Yetitech-Studio

[https://github.com/YetiTech-Studios/UE4GameLiftClientSDK/tree/688cc418cc3b7fe8e0eaae5aefbb3758ddc89120](https://www.youtube.com/redirect?q=https%3A%2F%2Fgithub.com%2FYetiTech-Studios%2FUE4GameLiftClientSDK%2Ftree%2F688cc418cc3b7fe8e0eaae5aefbb3758ddc89120&redir_token=-2JvVE0g4fraWQwMyDZDmpwdaE18MTU4ODgyODY3NUAxNTg4NzQyMjc1&event=comments&stzid=Ugxx0UK2HW0jX6q72qt4AaABAg.8zFDwJjDKbX8zVF3cYeAoz)

https://www.youtube.com/watch?v=2I8JDeMGkgc&t=736s

https://forums.awsgametech.com/



## Some Errors Collection

* **Unreal Engine 4.23 Compile Error**

  ```
  Error C4800 Implicit conversion from 'ADODB::_Recordset *const ' to bool. Possible information loss UE4 C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.25.28610\INCLUDE\comip.h 311
  
  Error C4800 Implicit conversion from 'ADODB::_Connection *const ' to bool. Possible information loss UE4 C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.25.28610\INCLUDE\comip.h 311
  
  Error MSB3075 The command "..\..\Build\BatchFiles\Build.bat -Target="UE4Editor Win64 Development" -Target="ShaderCompileWorker Win64 Development -Quiet" -WaitMutex -FromMsBuild" exited with code 5. Please verify that you have sufficient rights to run this command. UE4 C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Microsoft\VC\v160\Microsoft.MakeFile.Targets 44
  ```

  https://github.com/EpicGames/UnrealEngine/commit/25cefc81fe24c767eb995b0bb66b5611e0596973?diff=unified

* **Compile GameLiftServerSDK with Visual Studio 2019**

  ```
  Add environment variable: var name 'vs150comntools' to your user variable
  "...\VisualStudio\Common7\Tools"
  ```

* **Project Compile Error**

  ```
  LNK2005 "public: __cdecl Aws::GameLift::Server::Model::GameSession::~GameSession(void)" already defined in Module.GameLiftServerSDK.cpp.obj (aws-cpp-sdk-gamelift-server.lib)
  
  LNK2005 "public: __cdecl Aws::GameLift::Server::Model::GameSession::GameSession(class Aws::GameLift::Server::Model::GameSession const &)" already defined in Module.GameLiftServerSDK.cpp.obj (aws-cpp-sdk-gamelift-server.lib)
  ```

  You don't need to switch plugin, just need to:

  ```
  in the project .cs file change the order of the plugins and write the client version first for example :
  `PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "UMG", "GameLiftClientSDK", "GameLiftServerSDK" });`
  ```

  It will also fix `GameLiftServerSDK`.h cannot be opened when in Editor Target.

* **AWS Client Plugin Error**

  ```
  error C2039: 'clock_t' : is not a member of '`global namespace''
  ....
  ```
  
This error happens when I want to replace all source files related to aws with a new version of aws files.
  
You could change `GameLiftClientSDK\Source\AWSCore\Public\aws\core\platform\`  **Time.h** to **AWSTime.h** to fix it.
  
* **Resx file Problem**

  ```
  Couldn't process xxx file resx due to its being in the Internet or Restricted zone or having the mark of the web on the file
  ```

  Just find the file:

  * right click the file
  * tick the `unlock` 
  * click `ok` to apply

* **Run Client Application Error**

  ```
  Failed to load aws-cpp-sdk-core. Plugin will not be functional
  Failed to load aws-cpp-sdk-gamelift.
  Failed to load aws-cpp-sdk-cognito-identity. plugin will not be functional.
  ```

  Update Client Plugin: 

  [https://github.com/YetiTech-Studios/UE4GameLiftClientSDK/tree/688cc418cc3b7fe8e0eaae5aefbb3758ddc89120](https://www.youtube.com/redirect?q=https%3A%2F%2Fgithub.com%2FYetiTech-Studios%2FUE4GameLiftClientSDK%2Ftree%2F688cc418cc3b7fe8e0eaae5aefbb3758ddc89120&redir_token=-2JvVE0g4fraWQwMyDZDmpwdaE18MTU4ODgyODY3NUAxNTg4NzQyMjc1&event=comments&stzid=Ugxx0UK2HW0jX6q72qt4AaABAg.8zFDwJjDKbX8zVF3cYeAoz)
