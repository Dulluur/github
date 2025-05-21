import React, { useContext, useState } from "react";
import { useNavigate } from "react-router-dom";
import { AuthContext } from "@/context/AuthContext";
import { Button } from "@/components/ui/button";

export default function Login() {
  const { login } = useContext(AuthContext);
  const navigate = useNavigate();
  const [form, setForm] = useState({ login: "", password: "" });

  function onChange(e) {
    setForm({ ...form, [e.target.name]: e.target.value });
  }

  async function onSubmit(e) {
    e.preventDefault();
    try {
      await login(form);
      navigate("/dashboard", { replace: true });
    } catch {
      alert("Ошибка при входе");
    }
  }

  return (
    <div className="min-h-screen flex items-center justify-center bg-gray-50 dark:bg-gray-900 px-4">
      <div className="w-full max-w-md bg-white dark:bg-gray-800 rounded-lg shadow-lg p-8">
        <h2 className="text-2xl font-semibold text-gray-900 dark:text-gray-100 mb-6">
          Вход в личный кабинет
        </h2>
        <form onSubmit={onSubmit} className="space-y-4">
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              Логин
            </label>
            <input
              name="login"
              value={form.login}
              onChange={onChange}
              className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            />
          </div>
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              Пароль
            </label>
            <input
              type="password"
              name="password"
              value={form.password}
              onChange={onChange}
              className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            />
          </div>
          <Button type="submit" className="w-full">
            Войти
          </Button>
        </form>
      </div>
    </div>
  );
}
