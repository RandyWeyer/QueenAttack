# QueenAttack

#### _Queen Attack, 4/23/18_

#### By _**Alex Noble and Randy Weyer**_

## Description
_A program to determine if a player piece can be attacked by the enemy queen._

## Setup/Installation Requirements

* _Clone or download the repository._
* _Install C# with the .NET framework_
* _Locate and change to the QueenAttack.Tests directory in the terminal_
* _Run dotnet restore then dotnet test commands in the terminal_

## Specifications
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Given Queen location (0,0) and player piece (0,1)** | (0,0,0,1) | True |
| **Given Queen location (0,0) and player piece (1,0)** | (0,0,1,0) | True |
| **Given Queen location (0,0) and player piece (1,1)** | (0,0,1,1) | True |
| **Given Queen location (0,0) and player piece (1,2)**| (0,0,1,2) | False |
| **Given Queen location (0,0) and player piece (2,1)** | (0,0,2,1) | False |
| **Given Queen location (0,0) and player piece (7,7)** | (0,0,7,7) | True|


## Known Bugs

_No known bugs_


## Technologies Used
* C#/.NET

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Alex Noble, Randy Weyer_**
