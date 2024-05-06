import React,{useState} from 'react'
import "../EmployeeForm/Employee.css"
import pic from '../../assets/logo.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const GroupEmployee = () => {
    
    const [Group_id , setGroup_id] = useState('');
    const [Employee_id , setEmployee_id] = useState('');
    const [dateCreated , setdateCreated] = useState('');
    const [loading , setLoading] = useState(false);
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
            Group_id,
            Employee_id,
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
            <p class="quote">Add Into A Group Employee</p>
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
                    <label for="l-GroupName"></label>
                    <input type="Employee_id" GroupName="user-Employee_id" id="user-Employee_id" class="user-Employee_id" required  value={Employee_id}
                    onChange={(e) => setEmployee_id(e.target.value)}/>
                    <span>
                       Employee Id
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="mail">
                    </label>
                    <input type="Group_id" GroupName="mail" id="mail" required  value={Group_id}
                     onChange={(e) => setGroup_id(e.target.value)}/>
                    <span>
                        GroupEmployee ID
                    </span>
                    <div class="error"></div>
                </div>
    
    
                <div class="input-container">
                    <label for="user-Employee_id"></label>
                    <input  type="text" GroupName="l-GroupName" id="l-GroupName" required  value={dateCreated}
                    onChange={(e) => setdateCreated(e.target.value)}/>
                    <span>Date Joined</span>
                    <div class="error"></div>
                </div>

                <div class="input-container">
                    
                </div>

                <div id="btm">
                    <button type="submit" class="submit-btn" onClick={handleSaveMember}>Join GroupEmployee</button>
                </div>
            </div>
        </form>
    </main>  
    </>
  )
}

export default GroupEmployee