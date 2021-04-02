# <div align="center">**Animal Shelter API**</div>

#### <div align="center">*An animal shelter API with CRUD functionality*</div>

#### <div align="center">**By &copy; [Scott O'Neil](https://github.com/spnoneil), 4/2/2021**</div>
<br>
<br>
<br>


## Description
_A simple API, created for an Epicodus Coding School code review to practice/show knowledge of API creation and full CRUD implementation_


## Setup/Installation Requirements

* _Clone/download from GitHub (unzip, if necessary)_
* _Open terminal, navigate to the `AnimalShelterAPI` directory, inside the `AnimalShelter.Solution` root directory_


#### Database Setup

* _Download MySQL Workbench [here](https://dev.mysql.com/downloads/workbench/)_
* _After a successful install and setup, in the Administration tab in the GUI, hit "Data Import/Restore", followed by clicking "Import from Self-Contained File", and navigate to the included `scott_oneil.sql` dump structure file_
* _Click "Start Import"_
* _Next, in the directory of `AnimalShelterAPI`, create a file called `appsettings.json` and input the following, with "YOUR-PASSWORD-HERE" being the password you set up with MySQL workbench:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=scott_oneil;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Now, while still in the `AnimalShelterAPI` directory, and update the database with the command `dotnet ef database update` in the terminal_
* _Still in the terminal, enter `dotnet restore`._
* _Next, enter `dotnet build`_
* _Then, enter `dotnet run`_
* _Finally, in browser of choice, navigate to `http://localhost:5000`_
* _Now you're ready to head back to `http://localhost:5000` and to view API Swagger page_


## Technologies Used

* _C# / .NET 5.0 SDK / ASP .NET Core_
* _VS Code 1.54.2_
* _Entity Framework Core 5.0_
* _MySQL/Workbench 8.0.19_
* _Swashbuckle/Swagger v5.6.3_


## Known Bugs

* _No known bugs_

## Future implementation
* _Front end, full MVC implementation_
* _Styling_


## License
[![License: GPL](https://img.shields.io/badge/License-GPL-blue.svg)](https://opensource.org/licenses/gpl-license)

## Contact Information

_Issues can be reported [here](https://github.com/spnoneil/AnimalShelter.Solution/issues/new) on GitHub_
