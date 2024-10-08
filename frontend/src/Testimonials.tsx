import { useState, useEffect } from "react";
import Carousel from "react-bootstrap/Carousel";
import Card from "react-bootstrap/Card";
import { testimonialsEndpoint } from "./EndPoints/EndPoint";
import axios from "axios";
import "bootstrap/dist/css/bootstrap.min.css";
import styles from "./assets/Styles/Testimonials.module.css";

interface Testimonial {
  name: string;
  testimonial: string;
  image: string;
}

function Testimonials() {
  const [testimonials, setTestimonials] = useState<Testimonial[]>([]);
  const [index, setIndex] = useState(0);

  useEffect(() => {
    axios
      .get<Testimonial[]>(`${testimonialsEndpoint}`)
      .then((response) => {
        if (Array.isArray(response.data)) {
          setTestimonials(response.data);
        } else {
          console.error(
            "Expected an array of testimonials but received:",
            response.data
          );
        }
      })
      .catch((error) => {
        console.error("Error fetching testimonials:", error);
      });
  }, []);

  const handleSelect = (selectedIndex: number) => {
    setIndex(selectedIndex);
  };

  return (
    <>
      {/* Carousel for tablets and larger screens */}
      <Carousel
        activeIndex={index}
        onSelect={handleSelect}
        className={`${styles.testimonialsCarousel} d-none d-md-block`}
      >
        {testimonials.map((testimonial, idx) => (
          <Carousel.Item key={idx}>
            <Card
              style={{ width: "18rem", margin: "auto" }}
              className="text-center"
            >
              <Card.Img
                variant="top"
                src={testimonial.image}
                alt={testimonial.name}
                className={styles.top}
              />
              <Card.Body>
                <Card.Title>{testimonial.name}</Card.Title>
                <Card.Text>{testimonial.testimonial}</Card.Text>
              </Card.Body>
            </Card>
          </Carousel.Item>
        ))}
      </Carousel>

      {/* Grid layout for mobile screens */}
      <div className={`${styles.testimonialsPage} d-block d-md-none`}>
        {testimonials.map((testimonial, index) => (
          <Card key={index} style={{ width: "18rem", margin: "10px auto" }}>
            <Card.Img
              variant="top"
              src={testimonial.image}
              alt={testimonial.name}
              className={styles.top}
            />
            <Card.Body>
              <Card.Title>{testimonial.name}</Card.Title>
              <Card.Text>{testimonial.testimonial}</Card.Text>
            </Card.Body>
          </Card>
        ))}
      </div>
    </>
  );
}

export default Testimonials;
