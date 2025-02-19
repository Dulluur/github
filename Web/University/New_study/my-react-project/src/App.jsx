import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Footer from "./components/Footer"; 
import Home from "./pages/Home";
import About from "./pages/About";
import Blog from "./pages/Blog";
import "./App.css";

function App() {
  return (
    <Router>
      <Header />
      <h1 className="text-3xl font-bold underline">Hello world!</h1>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/about" element={<About />} />
        <Route path="/blog" element={<Blog />} />
      </Routes>
      <Footer />
    </Router>
  );
}

export default App;
