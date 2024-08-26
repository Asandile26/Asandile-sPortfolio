import {} from "react";
import Banner from "../assets/Images/Asandile-Langeni-3.jpeg";
import Styles from "../assets/Styles/LandingPage.module.css";

function LandingPage() {
  return (
    <div className={Styles.landingPage}>
      <div className={Styles.content}>
        <h1>
          Hi, It's <span className={Styles.sp1}>Asandile Langeni</span>
        </h1>
        <h3 className={Styles.text}>
          I am a <span></span>
        </h3>
        <p>
          I am in the early stages of my career and currently enjoy learning
          about the tech industry as I work towards finding my niche. I am from
          Khayelitsha and have a strong passion for learning new things and
          gaining more knowledge. I love connecting with new people and
          exploring different perspectives. When I'm not coding, you’ll likely
          find me watching sports or anime. My ultimate goal is to pursue a
          career in full-stack development, and I'm excited to continue growing
          in this dynamic field.
        </p>

        <div className={Styles.socialIcons}>
          <a href="https://github.com/Asandile26" target="_blank">
            <i className="bx bxl-github"></i>
          </a>
          <a href="https://twitter.com/LA_Nator21" target="_blank">
            <i className="bx bxl-twitter"></i>
          </a>
          <a href="https://m.facebook.com/100090013194612/" target="_blank">
            <i className="bx bxl-facebook"></i>
          </a>
          <a
            href="https://www.linkedin.com/in/asandile-langeni-05b027201/"
            target="_blank"
          >
            <i className="bx bxl-linkedin"></i>
          </a>
        </div>
      </div>
      <div className={Styles.Banner}>
        <img src={Banner} alt="profile picture" />
      </div>
    </div>
  );
}

export default LandingPage;
