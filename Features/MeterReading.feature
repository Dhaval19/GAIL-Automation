Feature: Tests16_MeterReading

Do Meter Reading For Customer

@tag1
Scenario: Genrate Invoice By Meter Reading
	Given Verify Meter Reading Page Is Loaded 
	Then Enter BP Number In Search Box
	Then Enter Current Reading And Meter Image
	And Click On Save Button To Generate Invoice
