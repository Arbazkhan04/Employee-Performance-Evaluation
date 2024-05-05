import React,{useState} from 'react'
import "../EmployeeForm/Employee.css"
import pic from '../../assets/logo.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const Evaluation = () => {
    
    const [Remarks , setRemarks] = useState('');
    const [metric_id , setmetric_id] = useState('');
    const [employee_id , setemployee_id] = useState('');
    const [DateOfEvaluation , setDateOfEvaluation] = useState('');
    const [rating , setrating] = useState('');
    const [loading , setLoading] = useState(false);
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
            Remarks,
            metric_id,
            employee_id,
            rating,
            DateOfEvaluation
        };
        
        setLoading(true);
        axios
          .post("http://localhost:4000/api/v1/candidate/register",data)
          .then(()=>{
            setLoading(false);
            navigate('/');
          })
          .catch((err)=>{
            setLoading(false);
            alert("FILL THE FORM CORRECTLY" + err)
            console.log(err)
    
          })
      };
    
  return (
    <>
    <main class="card-container slideUp-animation">
        
        <div class="image-container">
            <h1 class="company">EPE</h1>
            <img src={pic} class="illustration" alt=""/>
            <p class="quote">Evaluate A Employee</p>
            <a href="#btm" class="mobile-btm-nav">
                <img src={pic} alt="" />
            </a>
        </div>
        <form action="" method="">
            <div class="form-container slideRight-animation">
    
                <h1 class="form-header">
                    Get started
                </h1>
    
                <div class="input-container">
                    <label for="f-Remarks"></label>
                    <input type="text" Remarks="f-Remarks" id="f-Remarks" required  value={Remarks}
                    onChange={(e) => setRemarks(e.target.value)}/>
                    <span>
                        Remarks
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="l-Remarks"></label>
                    <input type="employee_id" Remarks="user-employee_id" id="user-employee_id" class="user-employee_id" required  value={employee_id}
                    onChange={(e) => setemployee_id(e.target.value)}/>
                    <span>
                       Employee ID
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="mail">
                    </label>
                    <input type="metric_id" Remarks="mail" id="mail" required  value={metric_id}
                     onChange={(e) => setmetric_id(e.target.value)}/>
                    <span>
                        Metric ID
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="phone">
                    </label>
                    <input type="tel" Remarks="phone" id="phone" required  value={rating}
                    onChange={(e) => setrating(e.target.value)}/>
                    <span>Rating</span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="user-employee_id"></label>
                    <input  type="text" Remarks="l-Remarks" id="l-Remarks" required  value={DateOfEvaluation}
                    onChange={(e) => setDateOfEvaluation(e.target.value)}/>
                    <span>Date Of Evaluation</span>
                    <div class="error"></div>
                </div>

                <div class="input-container">
                    
                </div>

                <div id="btm">
                    <button type="submit" class="submit-btn" onClick={handleSaveMember}>Evaluate</button>
                </div>
            </div>
        </form>
    </main>  
    </>
  )
}

export default Evaluation