# Employee Performance Evaluation

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python](https://img.shields.io/badge/Python-3.x-blue.svg)](https://python.org/)
[![Power BI](https://img.shields.io/badge/Power_BI-supported-orange.svg)](https://powerbi.microsoft.com/)
**Project Status:** [▓▓▓▓▓▓▓] (100% complete)

The Employee Performance Evaluation System is a comprehensive solution designed to assess and analyze employee performance using various metrics. This project integrates data analytics, ETL operations, and a web interface to provide a seamless and efficient HR dashboard.

![image](https://github.com/Arbazkhan04/Employee-Performance-Evaluation/assets/120156815/ba8de965-49bc-498f-ac0c-d5cf9d222a5f)


## Features

- **Power BI Dashboard**: For advanced analytics and visual representations of employee performance metrics.
- **Database Design**: Structured to handle complex relationships and large datasets efficiently.
- **Data Population and Cleaning**: Utilized Python and pandas library for data manipulation.
- **ETL Operations**: Employed SQL Server Integration Services (SSIS) for Extract, Transform, Load processes.
- **Web Application**: Developed an intuitive HR dashboard interface for ease of use.

## Tech Stack

- **Database**: SQL Server
- **ETL**: SSIS
- **Backend**: Node | Express
- **Frontend**: React 
- **Analytics**: Power BI
- **Data Cleaning**: pandas (Python library)

## Project Structure

```bash
├── data
│   ├── raw_data
│   └── cleaned_data
├── scripts
│   ├── data_population.py
│   └── data_cleaning.py
├── ssis
│   └── etl_package.dtsx
├── web
│   ├── frontend
│   └── backend
├── powerbi
│   └── dashboard.pbix
├── README.md
└── LICENSE
```

## Setup Instructions

1. Clone Repository
2. Setup Database. Use the provided SQL scripts in the database directory to create the necessary tables and relationships.
3. Install Web dependencies in web directory: `npm i` (for backend and frontend directories)
4. Run the web application (instructions within the code, typically `node app.js`).
5. Access the application in your web browser at the specified URL (usually `http://localhost:3000/`).
6. Launch Power Bi dashboard: Open the dashboard.pbix file in Power BI Desktop to view and interact with the analytics dashboard.

## Usage

The web application provides an interface for HR to interact with the data, generate reports, and perform CRUD operations.
The Power BI dashboard offers a visual representation of employee performance metrics and insights.

## Collaborators

- Abdur Rehman Kazim
- Arbaz Khan
- Muhammad Faizan Asim
- Aleena Sheikh
- Afeera Fatima

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

## Acknowledgements

Special thanks to our team and mentors who supported this project.
