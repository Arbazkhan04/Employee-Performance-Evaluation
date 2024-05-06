import React from 'react'
import "./About.css"

const AboutPage = () => {
  return (
    <>
    <br/><br/>
    <header>
        <h1>Employee Performance Evaluation (EPE) Project</h1>
    </header>
    <section>
        <h2>Project Overview</h2>
        <p>The Employee Performance Evaluation (EPE) project aims to develop a comprehensive system for managing and evaluating employee performance within an organization. The system includes modules for tracking employee information, department details, group management, metric definitions, and evaluation records.</p>
        <h2>System Modules</h2>
        <ul>
            <li>Employee Information Tracking</li>
            <li>Department Details Management</li>
            <li>Group Management</li>
            <li>Metric Definitions</li>
            <li>Evaluation Records</li>
        </ul>
        <h2>Key Features</h2>
        <ul>
            <li>Assignment of employees to departments and groups</li>
            <li>Supervisor assignment for each group for overseeing performance evaluations</li>
            <li>Definition of metrics for measuring various aspects of employee performance</li>
            <li>Periodic evaluations capturing ratings and remarks</li>
            <li>Data integrity and consistency ensured through normalization</li>
            <li>Enforcement of business rules to maintain evaluation accuracy</li>
            <li>User-friendly interface for administrators to manage employee and group information, conduct evaluations, and generate performance reports</li>
        </ul>
    </section>
    </>
  )
}

export default AboutPage