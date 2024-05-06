import React,{useState} from 'react'
import "../EmployeeForm/Employee.css"
import pic from '../../assets/logo.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const Supervisor = () => {
    

    const [Employee_id , SetEmployee_id] = useState('');
    const [loading , setLoading] = useState(false);
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
           
            Employee_id
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
            alert("FILL THE FORM CORRECTLY "+err)
            console.log(err)
    
          })
      };
    
  return (
    <>
    <main class="card-container slideUp-animation">
        
        <div class="image-container">
            <h1 class="company">EPE</h1>
            <img src={pic} class="illustration" alt=""/>
            <p class="quote">WOW BECOME A SUPERVISOR</p>
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
                    <label for="phone">
                    </label>
                    <input type="text" GroupName="phone" id="phone" required  value={Employee_id}
                    onChange={(e) => SetEmployee_id(e.target.value)}/>
                    <span>Employee ID</span>
                    <div class="error"></div>
                </div>
    
               

                <div id="btm">
                    <button type="submit" class="submit-btn" onClick={handleSaveMember}>Make Him Supervisor</button>
                </div>
            </div>
        </form>
    </main>  
    </>
  )
}

export default Supervisor