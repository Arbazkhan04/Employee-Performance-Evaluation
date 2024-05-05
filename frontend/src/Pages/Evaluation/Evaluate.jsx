import React from 'react'
import Evaluation from '../../Components/Evaluation/Evaluation'
import EvaluationGroup from '../../Components/Evaluation/EvaluateGroup'


const Evaluate = () => {
  return (
    <>
    <section class="section spacer"></section>

    <section class="section spacer"></section>
        <section class="section">
                    <div class="box-main">
                        <Evaluation/>
                    </div>
                </section>
                
    <section class="section spacer"></section>
    <section class="section spacer"></section>
    <h1 align="center"><br/>Evaluate A GROUP</h1>
<section class="section spacer"></section>
<section class="section spacer"></section>

    <section class="section">
                <div class="box-main">
                   <EvaluationGroup/>
                </div>
            </section>
            
<section class="section spacer"></section>
<section class="section spacer"></section>
    </>
  )
}

export default Evaluate