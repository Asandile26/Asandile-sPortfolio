import { useState, ChangeEvent, FormEvent } from "react";
import styleCon from "../assets/Styles/Contact.module.css";

interface FormData {
  fullName: string;
  email: string;
  message: string;
}

function Contact() {
  const [formData, setFormData] = useState<FormData>({
    fullName: "",
    email: "",
    message: "",
  });

  const handleChange = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = event.target;
    setFormData((formData) => ({
      ...formData,
      [name]: value,
    }));
  };

  const handleSubmit = async (event: FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    try {
      const response = await fetch("https://formspree.io/f/mleqyewv", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(formData),
      });

      if (response.ok) {
        alert("Form submitted successfully!");
        setFormData({
          fullName: "",
          email: "",
          message: "",
        });
      } else {
        alert("Form submission failed.");
      }
    } catch (error) {
      console.error("Error:", error);
      alert("Form submission failed.");
    }
  };

  return (
    <div className={styleCon.ContactPage}>
      <h3 className={styleCon.heading}>Contact us</h3>
      <div className={styleCon.contentWrapper}>
        <div className={styleCon.contactInfo}>
          <div className={styleCon.item}>
            <div className={styleCon.icon} style={{ fontSize: "3rem" }}>
              <i className="bx bxs-map"></i>
            </div>
            <div className={styleCon.text}>
              <h3>Address</h3>
              <p>
                W659 Ndlovu Cr <br /> Site B <br />
                Khayelitsha <br /> 7784
              </p>
            </div>
          </div>
          <div className={styleCon.item}>
            <div className={styleCon.icon} style={{ fontSize: "3rem" }}>
              <i className="bx bxs-phone"></i>
            </div>
            <div className={styleCon.text}>
              <h3>Email</h3>
              <p>asandilelangeni@gmail.com</p>
            </div>
          </div>
          <div className={styleCon.item}>
            <div className={styleCon.icon} style={{ fontSize: "3rem" }}>
              <i className="bx bxs-envelope"></i>
            </div>
            <div className={styleCon.text}>
              <h3>Phone</h3>
              <p>067 6555 678</p>
            </div>
          </div>
        </div>
        <div className={styleCon.formSection}>
          <form onSubmit={handleSubmit} className={styleCon.form}>
            <div className="mb-3">
              <label className="form-label">Full Name</label>
              <input
                type="text"
                className="form-control"
                id="exampleInputFirstName"
                name="fullName"
                value={formData.fullName}
                onChange={handleChange}
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Email address</label>
              <input
                type="email"
                className="form-control"
                id="exampleInputEmail1"
                name="email"
                value={formData.email}
                onChange={handleChange}
                aria-describedby="emailHelp"
              />
              <div id="emailHelp" className="form-text"></div>
            </div>
            <div className="mb-3">
              <label className="form-label">Message</label>
              <textarea
                className="form-control"
                id="exampleFormControlTextarea1"
                name="message"
                value={formData.message}
                onChange={handleChange}
              ></textarea>
            </div>
            <button type="submit" className={styleCon.submitBtn}>
              Submit
            </button>
          </form>
        </div>
      </div>
    </div>
  );
}

export default Contact;
