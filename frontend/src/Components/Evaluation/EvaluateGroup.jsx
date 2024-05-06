import React,{useState} from 'react'
import "../EmployeeForm/Employee.css"
import pic from '../../assets/logo.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const EvaluationGroup = () => {
    
    const [Remarks , setRemarks] = useState('');
    const [metric_id , setmetric_id] = useState('');
    const [Group_id , setGroup_id] = useState('');
    const [DateOfEvaluation , setDateOfEvaluation] = useState('');
    const [rating , setrating] = useState('');
    const [loading , setLoading] = useState(false);
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
            metric_id,
            group_id:Group_id,
            rating,
            remarks:Remarks
        };
        
        setLoading(true);
        axios
          .post("http://localhost:3000/evaluation/group",data)
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
            <p class="quote">Evaluate A Group</p>
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
                    <input type="Group_id" Remarks="user-Group_id" id="user-Group_id" class="user-Group_id" required  value={Group_id}
                    onChange={(e) => setGroup_id(e.target.value)}/>
                    <span>
                       Group ID
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
                    <label for="user-Group_id"></label>
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

export default EvaluationGroup