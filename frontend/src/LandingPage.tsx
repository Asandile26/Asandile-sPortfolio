import {} from "react";
import Banner from "./assets/Images/Asandile-Langeni-3.jpeg";
import Styles from "./assets/Styles/LandingPage.module.css";

function LandingPage() {
  return (
    <div className={Styles.landingPage}>
      <div className={Styles.content}>
        <h1>
          Hi, It's <span className={Styles.sp1}>Asandile Langeni</span>
        </h1>
        <h3 className={Styles.text}>
          I am <span></span>
        </h3>
        <p>
          I am in the early stage of my career and now, I enjoy learning about
          the industry so that I can find my niche. If I'm not coding I'm
          defitenly watching sport and anime.
        </p>
        <div className={Styles.socialIcons}>
          <a href=""></a>
          <a href=""></a>
          <a href=""></a>
          <a href=""></a>
        </div>
      </div>
      <div className={Styles.Banner}>
        <img src={Banner} alt="profile picture" />
      </div>
    </div>
  );
}

export default LandingPage;
