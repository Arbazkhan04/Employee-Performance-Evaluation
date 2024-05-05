import React from 'react'
import { Employee, GroupEmployee } from '../../Components'

const EmployeePage = () => {
  return (
    <>
    
<section class="section spacer"></section>

<section class="section spacer"></section>
    <section class="section">
                <div class="box-main">
                    <Employee/>
                </div>
            </section>
            
<section class="section spacer"></section>
<section class="section spacer"></section>
<h1 align="center"><br/>ADD EMPLOYEE IN GROUP</h1>
<section class="section spacer"></section>
<section class="section spacer"></section>

    <section class="section">
                <div class="box-main">
                    <GroupEmployee/>
                </div>
            </section>
            
<section class="section spacer"></section>
<section class="section spacer"></section>
    </>
  )
}

export default EmployeePage