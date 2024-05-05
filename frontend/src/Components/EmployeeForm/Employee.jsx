import React,{useState} from 'react'
import "./Employee.css"
import pic from '../../assets/logo.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const Employee = () => {
    
    const [ user_id, setid] = useState('');
    const [department , setdepid] = useState('');
    const [name , setfullName] = useState('');
    const [designation , setDesID] = useState('');
    
    const [loading , setLoading] = useState(false);
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
       user_id
      ,name
      ,department
      ,designation
        };
        console.log(data);
        setLoading(true);
        axios
          .post("http://localhost:4000/api/employee/",data)
          .then(()=>{
            setLoading(false);
            console.log("DONE")
            alert("DONE")
          })
          .catch((err)=>{
            setLoading(false);
            alert("FILL THE FORM CORRECTLY (DONT REUSE THE EMAIL) ")
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
     
        </div>
        <form action="" method="">
            <div class="form-container slideRight-animation">
    
                <h1 class="form-header">
                    Get started
                </h1>
    
              
                
                <div class="input-container">
              
                    <input type="text" name="name" id="f-name" required  value={name}
                    onChange={(e) => setfullName(e.target.value)}/>
                    <span>
                        Full Name
                    </span>
             
                </div>

                <div class="input-container">
     
                    <input type="text" name="department" id="department" class="department" required  value={department}
                    onChange={(e) => setdepid(e.target.value)}/>
                    <span>
                    Departement ID
                            </span>
          
                </div>
    
                <div class="input-container">
            
                    <input type="text" name="user_id" id="user_id" required  value={user_id}
                     onChange={(e) => setid(e.target.value)}/>
                    <span>
                        User ID
                    </span>

                </div>
    
                <div class="input-container">
             
                    <input type="text" name="designation" id="phone" required  value={designation}
                    onChange={(e) => setDesID(e.target.value)}/>
                    <span>designation</span>
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

export default Employee