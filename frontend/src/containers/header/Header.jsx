import React from 'react' 
import "./header.css"
import ai from "../../assets/ai1.png"

const Header = () => {
  return (
    <div className="woix__header section_padding" id='home'>
      <div className="woix__header-content">
        <h1 className="gradient__text">Let&apos;s Build Your Dreams with EPE</h1>
        <p>With EPE, your dreams are our blueprints, and your success is our mission. Let us help you turn your ideas into reality with innovative software solutions that leave a lasting impression in the world of websites, mobile apps, and games. Welcome to a world where creativity meets technology, and possibilities are limitless.
        Our passion lies in transforming creative ideas into cutting-edge software solutions that transcend expectations. With our unwavering commitment to excellence, we specialize in crafting a wide spectrum of digital experiences.</p>
      </div>
      <div className="woix__header-image">
      <img src={ai} alt="AI" />
      </div>
    </div>
  )
}

export default Header