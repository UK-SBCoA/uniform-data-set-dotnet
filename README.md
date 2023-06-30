# UDS for .NET

This software is intended for use by [National Institute on Aging (NIA) Alzheimer's Disease Research Centers](https://www.nia.nih.gov/research/dn/national-alzheimers-coordinating-center-nacc) (ADRCs) to collect data for submission to the National Alzheimer's Coordinating Center ([NACC](https://naccdata.org/)) database. This data set is called UDS (Uniform Data Set). All ADRC's submit this data to contribute to the NIA's Alzheimer's Disease Longitudinal Study.

## Get started quickly
This repository includes a running example of all necessary images to electronically collect data for UDS. While you could possibly use these images out-of-the-box, you should implement security best practices within your hosting environment, and potentially modify the code and build your own images to support your preferred authentication scheme. See below for links to the source code for the images.

### Steps
1. You'll need to authenticate to GitHub's container registry following the instructions [here](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-container-registry#authenticating-with-a-personal-access-token-classic).
2. Install Docker and clone this repository.
3. Create an .env file in the same directory as docker-compose. Include a variable for a SQL sa password `MSSQLSAPASSWORD=PasswordThatFollowsMSSQLRules1`.
4. Run `docker compose up` and the images will be pulled from GitHub with the app, api, and ms sql images.
5. App will be exposed on https://localhost:4811, api will be exposed on https://localhost:4801/swagger, and sql server on port 1188. If these ports are already in use, then you'll need to create your own docker-compose configuration.

## Contributing and image source code
If you are interested in contributing or modifying the images for yourself, you can find the source code in these repositories:

* [UK-SBCoA/uniform-data-set-dotnet-api](https://github.com/UK-SBCoA/uniform-data-set-dotnet-api)
* [UK-SBCoA/uniform-data-set-dotnet-web](https://github.com/UK-SBCoA/uniform-data-set-dotnet-web)

## License
The forms included in these images are copyrighted. Detailed copyright statements and usage restrictions are available on each form and on the [NACC website](https://naccdata.org/data-collection/guidelines-copyright). Non-ADRC researchers who wish to use the forms in this repository should [complete and return a permission request](https://files.alz.washington.edu/nacc-permission-form.pdf).

Code in this repository is Copyright (c) University of Kentucky Sanders-Brown Center on Aging. All rights reserved. Licensed under the [BSD 2-Clause "Simplified" License](LICENSE).
