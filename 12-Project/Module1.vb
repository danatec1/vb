Module Module1
    Public Ret As String '메시지 창 선택 여부를 저장할 변수 
    Public SQL As String 'SQL 문 사용에 필요한 변수
    Public Con As New OleDb.OleDbConnection '데이터베이스 연결 개체
    Public DCom As New OleDb.OleDbCommand '데이터베이스 조작 개체
    Public DA As New OleDb.OleDbDataAdapter '데이터베이스 적용 개체

    Public Sub DB_Access()
        Dim My_con As String
        My_con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\VB2019\database\library.accdb"
        Con.ConnectionString = My_con
        DCom.Connection = Con
        Con.Open()
    End Sub
End Module
