Feature: Tests17_InvoiceGeneration

Generate Invoice Of Customer

@tag1
Scenario: Test Invoice Generation Functionality
	Given Wait For Page to Load
	Then Search Customer By BP No
	Then Selct Date Filter
	And Click On Generate Invoice Button

