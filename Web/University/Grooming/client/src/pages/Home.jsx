import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { getAppointments } from "@/lib/utils/api";

export default function Home() {
  const [done, setDone] = useState([]);

  useEffect(() => {
    // временно мок или вызов API
    getAppointments(localStorage.getItem("token") || "").then((all) =>
      setDone(all.filter((a) => a.status === "Услуга оказана").slice(0, 4))
    );
  }, []);

  return (
    <div className="min-h-screen bg-gray-50 dark:bg-gray-900 flex flex-col items-center py-12 px-4">
      <div className="w-full max-w-3xl space-y-8 text-center">
        <h1 className="text-5xl font-extrabold text-gray-900 dark:text-white">
          GroomRoom
        </h1>
        <p className="text-gray-600 dark:text-gray-300">
          Портал для записи на услуги груминга домашних животных.
        </p>
        <div className="flex justify-center gap-4">
          <Link
            to="/login"
            className="inline-block px-6 py-2 bg-primary text-primary-foreground rounded shadow hover:bg-primary/90 transition"
          >
            Войти
          </Link>
          <Link
            to="/register"
            className="inline-block px-6 py-2 bg-secondary text-secondary-foreground rounded shadow hover:bg-secondary/90 transition"
          >
            Зарегистрироваться
          </Link>
        </div>

        <h2 className="mt-12 text-2xl font-semibold text-gray-800 dark:text-gray-200">
          Последние выполненные услуги
        </h2>
        <div className="grid grid-cols-1 sm:grid-cols-2 gap-6">
          {done.length > 0 ? (
            done.map((a) => (
              <div
                key={a.id}
                className="bg-white dark:bg-gray-800 rounded-lg shadow p-4"
              >
                <img
                  src={a.resultPhotoUrl}
                  alt={a.name}
                  className="w-full h-40 object-cover rounded-md"
                />
                <p className="mt-2 font-medium text-gray-900 dark:text-gray-100">
                  {a.name}
                </p>
              </div>
            ))
          ) : (
            <p className="col-span-full text-gray-500">Пока нет записей.</p>
          )}
        </div>
      </div>
    </div>
  );
}
