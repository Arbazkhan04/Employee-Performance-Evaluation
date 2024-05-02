import React,{useState} from 'react'
import "../Groups/Group.css"
import pic from '../../assets/ai1.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const Supervisor = () => {
    
    const [GroupName , setGroupName] = useState('');
    const [depId , setdepId] = useState('');
    const [supervisorID , setsupervisorID] = useState('');
    const [dateCreated , setdateCreated] = useState('');
    const [status_id , setstatus_id] = useState('');
    const [loading , setLoading] = useState(false);
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
            GroupName,
            depId,
            supervisorID,
            status_id,
            dateCreated
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
            alert("FILL THE FORM CORRECTLY (DONT REUSE THE depId) ")
            console.log(err)
    
          })
      };
    
  return (
    <>
    <main class="card-container slideUp-animation">
        
        <div class="image-container">
            <h1 class="company">EPE</h1>
            <img src={pic} class="illustration" alt=""/>
            <p class="quote">Register to get exciting opportunities..!</p>
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
                    <input type="text" GroupName="phone" id="phone" required  value={status_id}
                    onChange={(e) => setstatus_id(e.target.value)}/>
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