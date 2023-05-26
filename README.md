# UDS for .NET

This repository includes all necessary tools to electronically collect data for UDS within Docker images hosted in GitHub.

You'll need to authenticate to GitHub's container registry following the instructions [here](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-container-registry#authenticating-with-a-personal-access-token-classic).

Then you'll be able to clone this repository and run 'docker compose up'.

If you are interested in modifying the source code for each image, you can find it in these repositories:

* [UK-SBCoA/uniform-data-set-dotnet-api](https://github.com/UK-SBCoA/uniform-data-set-dotnet-api)
* [UK-SBCoA/uniform-data-set-dotnet-web](https://github.com/UK-SBCoA/uniform-data-set-dotnet-web)

This software is intended for use by [National Institute on Aging (NIA) Alzheimer's Disease Research Centers](https://www.nia.nih.gov/research/dn/national-alzheimers-coordinating-center-nacc) (ADRCs) to collect data for submission to the National Alzheimer's Coordinating Center ([NACC](https://naccdata.org/)) database. This data set is called UDS (Uniform Data Set). All ADRC's submit this data to contribute to the NIA's Alzheimer's Disease Longitudinal Study.

The software is implemented with several .NET tools and includes a development container for ease of use. You may choose to use the provided container or simply deploy the production container to your cloud storage provider. [More documentation can be found in our wiki.](https://github.com/UK-SBCoA/uniform-data-set-dotnet/wiki)

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

Read our [wiki](https://github.com/UK-SBCoA/uniform-data-set-dotnet/wiki) for more detailed information on each of these topics.

## License
The forms included in this repository are copyrighted. Detailed copyright statements and usage restrictions are available on each form and on the [[NACC website](https://naccdata.org/data-collection/guidelines-copyright). Non-ADRC researchers who wish to use the forms in this repository should [complete and return a permission request](https://files.alz.washington.edu/nacc-permission-form.pdf).

Code in this repository is Copyright (c) University of Kentucky Sanders-Brown Center on Aging. All rights reserved. Licensed under the BSD 2-Clause "Simplified" License.
