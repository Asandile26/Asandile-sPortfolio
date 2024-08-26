import { useState, useEffect } from "react";
import Spinner from "react-bootstrap/Spinner";
import "../assets/Styles/Resume.css";
import { resumeEndpoint } from "../EndPoints/EndPoint";

interface Resume {
  year: number;
  nameOfInstitution: string;
  description: string;
  startDate: Date;
  endDate: Date;
}

function Resume() {
  const [timelineData, setTimelineData] = useState<Resume[]>([]);
  const [loading, setLoading] = useState(true); // Add loading state

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
      .catch((error) => console.error("Error fetching timeline data:", error))
      .finally(() => setLoading(false)); // Set loading to false after data is fetched
  }, []);

  return (
    <div>
      <h3 className="headingRe">Resume</h3>

      {/* Display Spinner while loading */}
      {loading ? (
        <div className="text-center" style={{ marginTop: "15rem" }}>
          <Spinner animation="border" role="status">
            <span className="visually-hidden">Loading...</span>
          </Spinner>
        </div>
      ) : (
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
                  {item.startDate instanceof Date &&
                  !isNaN(item.startDate.getTime())
                    ? item.startDate.toLocaleDateString()
                    : item.startDate.toString()}{" "}
                  -{" "}
                  {item.endDate instanceof Date &&
                  !isNaN(item.endDate.getTime())
                    ? item.endDate.toLocaleDateString()
                    : item.endDate.toString()}
                </p>
              </div>
            ))}
            <div className="timeline-circle"></div>
          </div>
          <div className="timeline-circle"></div>
        </section>
      )}
    </div>
  );
}

export default Resume;
