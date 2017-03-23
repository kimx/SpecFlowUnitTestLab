Feature: HelloworldFeature
為了證實我懂基本用法，我需要實作第一個Hello world來測試

@mytag
Scenario: 加入兩個名稱
	Given 我輸入 "Kim" 為名字
	Given 我輸入 "Hsu" 為姓
	When 我按下查詢
	Then 應為 "Kim Hsu"
