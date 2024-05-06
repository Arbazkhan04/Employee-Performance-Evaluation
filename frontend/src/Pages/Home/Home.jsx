import React from 'react'
import "./Home.css"
const Home = () => {
    return (
<>

<section class="section spacer"></section>
            <section class="section">
            <div class="box-main">
                
                <p class="text-small">
                    <h1>Discription</h1>
                    The Employee Performance Evaluation (EPE) project aims to develop a comprehensive system for managing and evaluating employee performance within an organization.
                    The system includes modules for tracking employee information, department details, group management, metric definitions and evaluation record.
                        <br/>
                        Employees are assigned to departments and groups, with each group having a supervisor responsible for overseeing their performance evaluations. Metrics are defined as the measures of various aspects of employee performance, and evaluations are conducted periodically, capturing ratings and remarks for each employee.
                        <br/>
                            The system ensures data integrity and consistency through normalization and enforces business rules to maintain the accuracy of evaluation. It provides a user-friendly interface for administrators to manage employee and group information, conduct evaluations and generate performance reports.
                        </p>
                    </div>
                </section>

                <section class="section spacer"></section>
                <section class="section spacer"></section>
                
                <section class="section">
                    <div class="box-main">
                        <h2>Data Analysis Tools</h2>
                        <ul class="tool-list">  <li class="tool-card">
                            <h3>SQL Server Management Studio (SSMS)</h3>
                            <p>SSMS is a powerful tool for designing and managing relational databases based on the Entity-Relationship (ER) model. It allows for creating tables, defining relationships, and manipulating data efficiently.</p>
                        </li>
                            <li class="tool-card">
                                <h3>Power BI</h3>
                                <p>Developed by Microsoft, Power BI simplifies the data analysis process by offering a user-friendly interface with drag-and-drop functionalities. It allows for creating interactive visualizations like charts and dashboards to gain insights from your data.</p>
                            </li>
                            <li class="tool-card">
                                <h3>Web Pages</h3>
                                <p>Web pages provide an interactive platform for data analysis. By creating dashboards or reports accessible through a web browser, users can easily access and explore the data remotely.</p>
                            </li>
                            <li class="tool-card">
                                <h3>Informatica</h3>
                                <p>Informatica is a robust solution for data integration and Extract, Transform, Load (ETL) processes. It enables seamless data movement between different systems and databases, ensuring data consistency and quality for analysis.</p>
                            </li>
                            <li class="tool-card">
                                <h3>Pandas</h3>
                                <p>Pandas is a popular Python library specifically designed for data manipulation and analysis. It offers powerful functionalities for data cleaning, transformation, and exploration, making it a valuable tool for data scientists.</p>
                            </li>
                        </ul>
                    </div>
                </section>
                <section class="section spacer"></section>
</>


                )
}

                export default Home