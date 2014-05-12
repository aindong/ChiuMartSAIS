Module Configurations
    Public DB_Host As String = "localhost"
    Public DB_User As String = "root"
    Public DB_Pass As String = ""
    Public DB_Name As String = "chiumart"

    Public conString As String = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", DB_Host, DB_Name, DB_User, DB_Pass)
End Module
