Feature: Table
	測試資料集

@mytag
Scenario: 測試資料集
	Given 預計資料應有
    | ProductName        | UnitPrice  |
    | Kim's C# book      | 292        |
    | Kim's VB book      | 213        |
    | Kim's ASP.NET book | 224        |
	When 我按下查詢資枓
	Then 查詢結果應該有 3 筆