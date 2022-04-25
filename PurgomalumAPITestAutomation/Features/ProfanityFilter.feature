Feature: Profanity

Scenario: _01_Verify input text can be filtered based on an internal profanity list
	Given that PurgoMalum web service with resource he is so full of bullshit is loaded for a GET call
	Then the status code must be equal to OK
	And the following response must be retrieved from the profanity list
	| result                    |
	| he is so full of ******** |
	
Scenario:_02_Verify character alternates often used in place of standard alphabetic characters are filtered
	Given that PurgoMalum web service with resource he is an @sshole and a $lut is loaded for a GET call
	Then the status code must be equal to OK
	And the following response must be retrieved from the profanity list
	| result                      |
	| he is an ******* and a **** |

Scenario: _03_Verify comma separated profanity list replaced with accepted characters are allowed
	Given that PurgoMalum web service with resource ar3e,ar3ehol7,bastar6,cl7t,dag8,go33amn,le8bo,k5ke,ngg1 is loaded for a GET call
	Then the status code must be equal to OK
	And the following response must be retrieved from the profanity list
	| result                                                  |
	| ar3e,ar3ehol7,bastar6,cl7t,dag8,go33amn,le8bo,k5ke,ngg1 |


Scenario: _04_Verify input profanity text using various optional parameters:
	Given that PurgoMalum web service with resource this is some fucking test input&add=input&fill_char=_ is loaded for a GET call
	Then the status code must be equal to OK
	And the following response must be retrieved from the profanity list
	| result                          |
	| this is some _______ test _____ |


Scenario: _05_Verify input profanity text using fill_text parameter
	Given that PurgoMalum web service with resource this is some blump test input&add=input&fill_text={} is loaded for a GET call
	Then the status code must be equal to OK
	And the following response must be retrieved from the profanity list
	| result                  |
	| this is some {} test {} |


Scenario: _06_Verify input profanity text using fill_char parameter
	Given that PurgoMalum web service with resource this is some coon test &fill_char=~ is loaded for a GET call
	Then the status code must be equal to OK
	And the following response must be retrieved from the profanity list
	| result                 |
	| this is some ~~~~ test |
