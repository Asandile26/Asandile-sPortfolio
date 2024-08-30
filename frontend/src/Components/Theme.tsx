import React from "react";
import sun from "../assets/Images/Sun.svg";
import moon from "../assets/Images/Moon.svg";
import "../assets/Styles/Theme.css";

function Theme() {
  const setDarkMode = (): void => {
    document.querySelector("body")?.setAttribute("data-theme", "dark");
    localStorage.setItem("selectedTheme", "dark");
  };

  const setLightMode = (): void => {
    document.querySelector("body")?.setAttribute("data-theme", "light");
    localStorage.setItem("selectedTheme", "light");
  };

  const selectedTheme = localStorage.getItem("selectedTheme");

  if (selectedTheme === "dark") {
    setDarkMode();
  }

  const toggleTheme = (e: React.ChangeEvent<HTMLInputElement>): void => {
    if (e.target.checked) setDarkMode();
    else setLightMode();
  };

  return (
    <div className="dark_mode">
      <input
        type="checkbox"
        className="dark_mode_input"
        id="darkmode-toggle"
        onChange={toggleTheme}
        defaultChecked={selectedTheme === "dark"}
      />
      <label htmlFor="darkmode-toggle" className="dark_mode_label">
        <img src={sun} alt="Sun icon" className="sun" />
        <img src={moon} alt="Moon icon" className="moon" />
      </label>
    </div>
  );
}

export default Theme;
