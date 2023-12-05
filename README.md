# Connect Existing Database
**Connecting existing SQLServer database with dotnet application**

## Install required Dependencies
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

## Command used :
  ```
  Scaffold-DbContext "Server=Server-Name;Database=Database-Name;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
  ```
  - Replace the __Server-Name__ with your server name.
  - Replace the __Database-Name__ with your database name.
  - For adding annotations in the model created by this command , you should add __--data-annotation__ in the existing command.
    ```
    Scaffold-DbContext "Server=Server-Name;Database=Database-Name;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models --data-annotations
    ```
## Points to remember
- If yout are using __Windows Authentication__ in ' Sql Server Management Studio ' than you donot need to add UserId and Password in the command.
- But, if you are usinf __Sql Server Authentication__ than you must use this command.
  ```
  Scaffold-DbContext "Server=YourServerName;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
  ```

