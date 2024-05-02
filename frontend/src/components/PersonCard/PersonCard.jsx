import React from 'react'
import log from '../../assets/logo.png'
import faizan from '../../assets/faizan.png'
import afeera from '../../assets/Afeera.png'
import barr from '../../assets/Barr.png'
import anas from '../../assets/Anas.png'
import kazim from '../../assets/kazim.png'
import khuram from '../../assets/KHURAM.png'
import './cardStyle.css'

function checker(person){
if(person.name === "Muhammad Faizan Asim")
{
  return faizan;
}
else if(person.name === "Muhammad Abdul Barr")
{
  return barr;
}
else if(person.name === "Afeera Fatima")
{
  return afeera;
}
else if(person.name === "Abdur Rehman Kazim")
{
  return kazim;
}
else if(person.name === "Anas Mustafa ")
{
  return anas;
}
else if(person.name === "Khuram Iqbal")
{
  return khuram;
}
return log;
}

const PersonCard = ({person}) => {

  return (
    <main>
      <section>
        <div class="container">
          <div class="card">
            <div class="shoeBackground">
              <div class="gradients">
                <div class="gradient second" color="blue"></div>
             </div>
              <h1 class="nike"></h1>
              <img src = {log} alt="Logo" class="logo" />
              <a href="#" ><i class="fas fa-share-alt"></i></a>

              <img
                src={checker(person)}
                alt="Shoe Blue"
                
                color="blue"className='shoeBackground'
              />
            </div>
            <div class="info">
              <div class="shoeName">
                <div>
                  <h1 class="big">{person.name}</h1>
                </div>
                <h3 class="small"><br/>{person.works}</h3>
              </div>
              <div class="description">
                <h3 class="title"><br/>Information</h3>
                <p class="text"><br/>
                 {person.details}
                 </p>
              </div>
              <div class="buy-price">
                <a href={person.linkdin} class="buy">
                  <i class="fas fa-shopping-cart"></i>
                  Details
                </a>
              </div>
            </div>
          </div>
        </div>
      </section>
    </main>
  )
}

export default PersonCard