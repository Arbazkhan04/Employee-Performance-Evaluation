import React from 'react'
import "./productCard.css"
import web from "../../../assets/web.png"
import logo from "../../../assets/ai1.png"
import and from "../../../assets/andriod.png"
import graph from "../../../assets/graphics.png"



const PoductsCard = ({product}) => {
 
 
  return (
<main>
  <div>
    <div class="image-container">
    </div>
    <section class="info-section">
      <h1>{product.name}</h1>
      <h2>
        {product.category}
      </h2>
      <p>{product.description}</p>
      <div class="pricing">
        <p>{product.PersonAvaliable}  Employees</p>
        <button>
          <img src={Checker(product)} />
        </button>
      </div>

    </section>

  </div>
  </main>


    )
}
function Checker (product){
 
  if(product.category === "WEBSITE")
  {
    return web;
  }
  else if(product.category === "DEVELOPMENT")
  {
    return and;
  }
  
  else if(product.category == "DESIGNS")
  {
    return graph;
  }
  else 
  {
   return logo;
  }
 }
export default PoductsCard