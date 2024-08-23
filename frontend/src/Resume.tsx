import { useState, useEffect } from "react";
import "./assets/Styles/Resume.css";
import { resumeEndpoint } from "./EndPoints/EndPoint";

interface Resume {
  year: number;
  nameOfInstitution: string;
  description: string;
  startDate: Date;
  endDate: Date;
}

function Resume() {
  const [timelineData, setTimelineData] = useState<Resume[]>([]);

  useEffect(() => {
    fetch(`${resumeEndpoint}`)
      .then((response) => response.json())
      .then((data) => {
        const formattedData = data.map((item: any) => ({
          ...item,
          startDate: new Date(item.startDate),
          endDate: new Date(item.endDate),
        }));
        setTimelineData(formattedData);
      })
      .catch((error) => console.error("Error fetching timeline data:", error));
  }, []);

  return (
    <div>
      <section className="design-section">
        <div className="timeline-circle"></div>
        <div className="timeline">
          <div className="timeline-middle"></div>
          <div className="timeline-circle"></div>
          {timelineData.map((item, index) => (
            <div key={index} className="timeline-component timeline-content">
              <h2>{item.year}</h2>
              <h3>{item.nameOfInstitution}</h3>
              <p>{item.description}</p>
              <p>
                {/* Convert Date objects to strings for rendering */}
                {item.startDate instanceof Date &&
                !isNaN(item.startDate.getTime())
                  ? item.startDate.toLocaleDateString()
                  : item.startDate.toString()}{" "}
                -{" "}
                {item.endDate instanceof Date && !isNaN(item.endDate.getTime())
                  ? item.endDate.toLocaleDateString()
                  : item.endDate.toString()}
              </p>
            </div>
          ))}
          <div className="timeline-circle"></div>
        </div>
        <div className="timeline-circle"></div>
      </section>
    </div>
  );
}

export default Resume;
