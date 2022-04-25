# HometrackTestAutomation
This explains what Purgomalum project does. 

PurgoMalum is a simple, free, RESTful web service for filtering and removing content of profanity, obscenity
and other unwanted text. PurgoMalum's interface accepts several parameters for customisation.

This API Test automation Framework and Test scenarios are built using C# as the programming language, Specflow as a BDD tool 
and Restsharp library for HTTP methods (mainly covered a GET request for now).

The project name is PurgomalumAPITestAutomation. The project is structured using Page Object Model where 4 different folders were created 
to house individual classes to catter for different needs.

Folder Structrure:
- Feature folder is where the test scenarios for the system under test (SUT) are kept.

-StepDefinitions folder is where the generated steps for the scenarios are kept.

-SetUp folder is where the baseUrl and the code to drive the test are kept.

-Model folder is where all the test data (both expected and actual) properties are kept. 
For example, reason property was used to deserialiaze the result of GET call. Also, this same property was also 
used to format the test data from scenarios so that it could match the actual result format.

How to execute the test:
The test can be executed by opening the Test Explorer and click on the top left hand corner test run icon to run all tests in view
or by right clicking on individual test scenarios and select 'Run' to execute the selected test.


Questions and Answers
1.	How long did you spend on the technical test? What would you add to your solution if you had more time? 
If you didn't spend much time on the technical test, then use this as an opportunity to explain what you would add?
Answer: I spent 2hours on this technical test and If I have had more time or If I'm at work I would have added Test setting file
to keep the baseUrl and also add Extent reports to generates HTML reports.

2.	What do you think is the most interesting trend in test automation?
Answer: The most interesting trend in test automation for me is that, It allows us to manage regeression testing efficiently because
this days, companies delivers new feature often to an application under test and for QA to be able to cope with that volume of deployment
we also need to have a set of test in place to do quick check so that we can deliver on time. which covers UI, API and Other backend testing.

3.	What other test types would you include?
Answer: Error detection test.
