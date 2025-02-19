import { Link } from "react-router-dom";

export default function Footer() {
  return (
    <footer className="p-4 bg-gray-800 text-white text-center mt-10">
      <nav>
        <ul className="flex justify-center gap-4">
          <li><Link to="/" className="hover:underline">Главная</Link></li>
          <li><Link to="/about" className="hover:underline">О нас</Link></li>
          <li><Link to="/blog" className="hover:underline">Блог</Link></li>
        </ul>
      </nav>
      <p className="mt-2 text-sm">© 2025 Все права защищены</p>
    </footer>
  );
}
