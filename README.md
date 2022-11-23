# UDS for .NET

This repository includes all necessary tools to electronically collect data for UDS including

* UDS instruments as HTML forms (additionally, packaged with Nuget)
* QC rules
* Data persistence
* Development container
* Production container

This software is intended for use by [National Institute on Aging (NIA) Alzheimer's Disease Research Centers](https://www.nia.nih.gov/research/dn/national-alzheimers-coordinating-center-nacc) (ADRCs) to collect data for submission to the National Alzheimer's Coordinating Center ([NACC](https://naccdata.org/)) database. This data set is called UDS (Uniform Data Set). All ADRC's submit this data to contribute to the NIA's Alzheimer's Disease Longitudinal Study.

The software is implemented with several .NET tools and includes a development container for ease of use. You may choose to use the provided container or simply deploy the production container to your cloud storage provider. [More documentation can be found in our wiki.](Wiki)

## Development Setup

### Docker Compose Environment Variables
To run this project you will need to create a **.env** file at the root of the directory. In the .env file you will need to add one variable **MSSQLSAPASSWORD** and set it equal to a password that meets MS SQL Server password requirements for an SA account, this will be used in the docker-compose file to configure the MS SQL Server container.

### Creating appsettings.development.json
Next you will need to create a appsettings.Development.json for both **UDS.NET.API** and **UDS.Net.Web.MVC** copying the settings from appsettings.DEFAULT.json. You will then need to set the connection string with using the SA account and the password you created in the previous step.

### Running the app
 Once you have completed the previous steps you can open the project in visual studio and run docker compose configuration from the debugger or you can run the following command at the root of the project to run the containers independent of visual studio
 ```
 docker compose up -d
 ```

## Contributing
Thank you for interest in contributing to our project! There are many ways you can help:
* Submit bugs and feature requests [here](Discussions)
* Submit a fix by forking and submitting a PR Request [here](CONTRIBUTING.md)

## Security
[Security reports](SECURITY.md)

## Feedback
* Request a [new feature](Discussions)
* Submit a [bug report](Issues)
* [Upvote](Discussions) popular feature requests

Read our [wiki](Wiki) for more detailed information on each of these topics.

## License
The forms included in this repository are copyrighted. Detailed copyright statements and usage restrictions are available on each form and on the [[NACC website](https://naccdata.org/data-collection/guidelines-copyright). Non-ADRC researchers who wish to use the forms in this repository should [complete and return a permission request](https://files.alz.washington.edu/nacc-permission-form.pdf).

Code in this repository is Copyright (c) University of Kentucky Sanders-Brown Center on Aging. All rights reserved. Licensed under the BSD 2-Clause "Simplified" License.
