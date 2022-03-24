# Mltest (MagniLearn - Test Project)

This project was created using Angular version 13.3.0.

## How To Test

Please, clone the code and run `ng serve` from the terminal. Navigate to `http://localhost:4200/login`..

## Application Login Credentials

There is a simple login form where you need to enter the user ID. Please, use the following IDs for testing:

`0` -> Teacher Profile
`1` -> User Profile
`2` -> User Profile

This project does not uses a proper authentication feature, so, if you choose an ID different than the suggested ones, the application will redirect to a blank page.

## Requesting the back-end engine

Please, open the back-end project located in the folder named `mltest.backend`. This is an ASP.NET Core Web API project.
The back-end project is structured as the following:
`mltest.Domain`: Models and Repository contracts.
`mltest.Domain.Api`: Controllers, DI configuration.
`mltest.Domain.Infra`:  DTOs, Repository implementation (Dapper).

Please, select the API project as the starting one and run the application. Then, you´ll be able to use the front-end.

## Database

Please, import the DB Dump located in the folder named `Dump20220324`. The tables structure and data can be used from the dump files.

The credentials are the following:
`user` -> root
`password` -> pear0609