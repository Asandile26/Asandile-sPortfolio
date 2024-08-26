import {} from "react";
import styleSki from "../assets/Styles/Skills.module.css";

function Skills() {
  return (
    <div>
      <h2 className={styleSki.subTitle}>Skills</h2>
      <section>
        <div className={styleSki.container2} id="skills">
          <h3 className={styleSki.heading}>Technical skills</h3>
          <div className={styleSki.technical}>
            <div className={styleSki.bar}>
              <i className="bx bxl-html5" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>HTML</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.html}`}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxl-vuejs" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>VUE</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.vue} `}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxl-bootstrap" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>BOOTSTRAP</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.bootstrap}`}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxs-certification" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>Azure</span>
              </div>
            </div>

            <div
              className={`${styleSki.progressLine} ${styleSki.certification}`}
            >
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxs-data" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>Database(SQL)</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.data}`}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxl-css3" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>CSS</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.css}`}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxl-javascript" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>JAVASCRIPT</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.javascript}`}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxl-react" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>REACT</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.react}`}>
              <span></span>
            </div>
            <div className={styleSki.bar}>
              <i className="bx bxl-typescript" style={{ width: "7rem" }}></i>
              <div className={styleSki.info}>
                <span>TYPESCRIPT</span>
              </div>
            </div>
            <div className={`${styleSki.progressLine} ${styleSki.typescript}`}>
              <span></span>
            </div>
          </div>
        </div>
        <div className={styleSki.container1}>
          <h2 className={styleSki.heading}>Soft Skills</h2>
          <div className={styleSki.radialBars}>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path1}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>90%</div>
              <div className={styleSki.text}>Comminication</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path2}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>82%</div>
              <div className={styleSki.text}>Creativity</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path3}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>90%</div>
              <div className={styleSki.text}>Analytic</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path4}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>95%</div>
              <div className={styleSki.text}>Team player</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path5}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>90%</div>
              <div className={styleSki.text}>Time management</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path6}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>80%</div>
              <div className={styleSki.text}>Inquisitive</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path7}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>75%</div>
              <div className={styleSki.text}>Problem solver</div>
            </div>
            <div className={styleSki.radialBar}>
              <svg x="0px" y="0px" viewBox="0 0 200 200">
                <circle
                  className={styleSki.progressBar}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
                <circle
                  className={`${styleSki.path} ${styleSki.path8}`}
                  cx={100}
                  cy={100}
                  r={80}
                ></circle>
              </svg>
              <div className={styleSki.percentage}>92%</div>
              <div className={styleSki.text}>Resilience</div>
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}

export default Skills;
