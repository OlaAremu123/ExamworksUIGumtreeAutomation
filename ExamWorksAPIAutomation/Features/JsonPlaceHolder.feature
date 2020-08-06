Feature: JsonPlaceHolder

Scenario: API_JsonPlaceHolder_01_Verify that existing records can be retrieved from posts resource
	Given that JsonPlaceHolder web services with GET endpoint /posts is running
	Then the status code for GET endpoint is equal to OK
	And the following records should be retrieved from posts
