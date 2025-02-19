import { Link } from "react-router-dom";

export default function Header() {
  return (
    <nav className="p-4 bg-blue-500 text-white">
      <ul className="flex gap-4">
        <li><Link to="/" className="hover:underline">Главная</Link></li>
        <li><Link to="/about" className="hover:underline">О нас</Link></li>
        <li><Link to="/blog" className="hover:underline">Блог</Link></li>
      </ul>
    </nav>
  );
}