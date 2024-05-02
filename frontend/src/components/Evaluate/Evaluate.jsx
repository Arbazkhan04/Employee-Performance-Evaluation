import React,{useState} from 'react'
import "../Groups/Group.css"
import pic from '../../assets/ai1.png'
import axios from 'axios'
import { useNavigate } from 'react-router-dom'

const Evaluate = () => {
    
    const [Metric_id , setMetric_id] = useState('');
    const [Employee_Id , setEmployee_Id] = useState('');
    const [EvaluateID , setEvaluateID] = useState('');
    const [dateCreated , setdateCreated] = useState('');
    const [Rating , setRating] = useState('');
    const [loading , setLoading] = useState(false);
    const remarks = "NOPE"
    const navigate = useNavigate();
    const handleSaveMember = ()=>{
        const data = {
            Metric_id,
            Employee_Id,
            Rating,
            dateCreated,
            remarks
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
            alert("FILL THE FORM CORRECTLY (DONT REUSE THE Employee_Id) ")
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
              
                    <input type="text" name="name" id="f-name" required  value={Metric_id}
                    onChange={(e) => setMetric_id(e.target.value)}/>
                    <span>
                    Metric_id
                    </span>
             
                </div>

                <div class="input-container">
     
                    <input type="text" name="department" id="department" class="department" required  value={Employee_Id}
                    onChange={(e) => setEmployee_Id(e.target.value)}/>
                    <span>
                    Employee_Id
                            </span>
          
                </div>
    
                <div class="input-container">
            
                    <input type="text" name="user_id" id="user_id" required  value={Rating}
                     onChange={(e) => setRating(e.target.value)}/>
                    <span>
                        Rating
                    </span>

                </div>
    
                <div class="input-container">
             
                    <input type="text" name="designation" id="phone" required  value={dateCreated}
                    onChange={(e) => setdateCreated(e.target.value)}/>
                    <span>Date Created</span>
                </div>
    

            
    
               

                <div id="btm">
                    <button type="submit" class="submit-btn" onClick={handleSaveMember}>Make Him Evaluate</button>
                </div>
            </div>
        </form>
    </main>  
    </>
  )
}

export default Evaluate