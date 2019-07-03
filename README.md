# easy-peasy-rent-application

[![standard-readme compliant](https://img.shields.io/badge/standard--readme-OK-green.svg?style=flat-square)](https://github.com/RichardLitt/standard-readme)

> An application to make your life easier when you want to try out but not to bye


TODO: Fill out this long description.

## Table of Contents

- [easy-peasy-rent-application](#easy-peasy-rent-application)
  - [Table of Contents](#Table-of-Contents)
  - [Stack](#Stack)
  - [Install](#Install)
  - [Database](#Database)
  - [Usage](#Usage)
  - [Maintainers](#Maintainers)
  - [Contributing](#Contributing)
  - [License](#License)

## Stack
- [ASP.Net Core MVC](https://github.com/aspnet/AspNetCore)
- [React.Net](https://github.com/reactjs/React.NET)
- [Webpack](https://webpack.js.org/)
- [React-helmet](https://github.com/nfl/react-helmet)
- [Styled-components](https://www.styled-components.com/)
- [React-router](https://github.com/ReactTraining/react-router)

## Install
> install npm packages

```
    npm install
```

## Database
You should use PostgreSQL for this project. When you install this DBMS you will have to create database and user with will be owner for DB.

Database connection string have to contain:
1. host and port (taken from DBMS configs).
2. username, password, database name (taken from previous step).
Example:
```
    Server=localhost;User Id=RentApp;Password=easy;Database=RentBase;
```

> If you need add/update migration of the project you have to type in package manager console:

```
    Add-Migration Initial
```

> If you want generate/update database by migration files you have to type:

```
    Update-Database
```

## Usage
> build in development mode
```
    npm run start
```
> make a poduction ready build
```
    npm run build 
```

## Maintainers

[@maximsan](https://github.com/maximsan)

## Contributing

PRs accepted.

Small note: If editing the README, please conform to the [standard-readme](https://github.com/RichardLitt/standard-readme) specification.

## License

MIT © 2019 maximsan
