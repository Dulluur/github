import React, { useContext, useState } from "react";
import { useNavigate } from "react-router-dom";
import { register } from "@/lib/utils/api";
import { AuthContext } from "@/context/AuthContext";
import { Button } from "@/components/ui/button";

export default function Register() {
  const { login: autoLogin } = useContext(AuthContext);
  const navigate = useNavigate();
  const [form, setForm] = useState({
    fullName: "",
    login: "",
    email: "",
    password: "",
    password2: "",
    agree: false
  });

  function onChange(e) {
    const { name, value, type, checked } = e.target;
    setForm({
      ...form,
      [name]: type === "checkbox" ? checked : value
    });
  }

  async function onSubmit(e) {
    e.preventDefault();
    try {
      await register(form);
      await autoLogin({ login: form.login, password: form.password });
      navigate("/dashboard", { replace: true });
    } catch {
      alert("Ошибка при регистрации");
    }
  }

  return (
    <div className="min-h-screen flex items-center justify-center bg-gray-50 dark:bg-gray-900 px-4">
      <div className="w-full max-w-lg bg-white dark:bg-gray-800 rounded-lg shadow-lg p-8">
        <h2 className="text-2xl font-semibold text-gray-900 dark:text-gray-100 mb-6">
          Регистрация пользователя
        </h2>
        <form onSubmit={onSubmit} className="space-y-4">
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              ФИО
            </label>
            <input
              name="fullName"
              onChange={onChange}
              className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            />
          </div>
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              Логин
            </label>
            <input
              name="login"
              onChange={onChange}
              className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            />
          </div>
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              Email
            </label>
            <input
              name="email"
              type="email"
              onChange={onChange}
              className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            />
          </div>
          <div className="grid grid-cols-2 gap-4">
            <div>
              <label className="block text-gray-700 dark:text-gray-300 mb-1">
                Пароль
              </label>
              <input
                name="password"
                type="password"
                onChange={onChange}
                className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              />
            </div>
            <div>
              <label className="block text-gray-700 dark:text-gray-300 mb-1">
                Повтор пароля
              </label>
              <input
                name="password2"
                type="password"
                onChange={onChange}
                className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
              />
            </div>
          </div>
          <div className="flex items-center space-x-2">
            <input
              type="checkbox"
              name="agree"
              onChange={onChange}
              className="h-4 w-4 text-primary focus:ring-primary border-gray-300 rounded"
            />
            <label className="text-gray-700 dark:text-gray-300">
              Согласен на обработку персональных данных
            </label>
          </div>
          <Button type="submit" className="w-full">
            Зарегистрироваться
          </Button>
        </form>
      </div>
    </div>
  );
}
