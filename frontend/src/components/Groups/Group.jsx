import React,{useState} from 'react'
import "./Group.css"
import pic from '../../assets/ai1.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const Group = () => {
    
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
                    <label for="f-GroupName"></label>
                    <input type="text" GroupName="f-GroupName" id="f-GroupName" required  value={GroupName}
                    onChange={(e) => setGroupName(e.target.value)}/>
                    <span>
                        Full GroupName
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="l-GroupName"></label>
                    <input type="supervisorID" GroupName="user-supervisorID" id="user-supervisorID" class="user-supervisorID" required  value={supervisorID}
                    onChange={(e) => setsupervisorID(e.target.value)}/>
                    <span>
                       supervisorID
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="mail">
                    </label>
                    <input type="depId" GroupName="mail" id="mail" required  value={depId}
                     onChange={(e) => setdepId(e.target.value)}/>
                    <span>
                        User ID 
                    </span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="phone">
                    </label>
                    <input type="tel" GroupName="phone" id="phone" required  value={status_id}
                    onChange={(e) => setstatus_id(e.target.value)}/>
                    <span>status_id</span>
                    <div class="error"></div>
                </div>
    
                <div class="input-container">
                    <label for="user-supervisorID"></label>
                    <input  type="text" GroupName="l-GroupName" id="l-GroupName" required  value={dateCreated}
                    onChange={(e) => setdateCreated(e.target.value)}/>
                    <span>dateCreated</span>
                    <div class="error"></div>
                </div>

                <div class="input-container">
                    
                </div>

                <div id="btm">
                    <button type="submit" class="submit-btn" onClick={handleSaveMember}>Apply</button>
                </div>
            </div>
        </form>
    </main>  
    </>
  )
}

export default Group