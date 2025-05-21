import React, { useContext, useEffect, useState } from "react";
import { AuthContext } from "@/context/AuthContext";
import { getAppointments, updateAppointmentStatus } from "@/lib/utils/api";
import { Button } from "@/components/ui/button";

export default function AdminDashboard() {
  const { token } = useContext(AuthContext);
  const [appointments, setAppointments] = useState([]);

  useEffect(() => {
    getAppointments(token).then(setAppointments);
  }, []);

  async function handleStatus(id, status, file = null) {
    await updateAppointmentStatus(token, id, status, file);
    setAppointments(await getAppointments(token));
  }

  return (
    <div className="min-h-screen bg-gray-50 dark:bg-gray-900 py-12 px-4 flex flex-col items-center">
      <div className="w-full max-w-3xl space-y-6">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-gray-100">
          Панель администратора
        </h1>
        {appointments.map((a) => (
          <div
            key={a.id}
            className="bg-white dark:bg-gray-800 rounded-lg shadow p-6 space-y-3"
          >
            <p className="font-medium text-gray-900 dark:text-gray-100">
              Питомец: {a.name}
            </p>
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Текущий статус: {a.status}
            </p>

            {a.status === "Новая" && (
              <>
                <Button
                  onClick={() => handleStatus(a.id, "Обработка данных")}
                >
                  В обработку
                </Button>
              </>
            )}

            {a.status === "Обработка данных" && (
              <div className="space-y-2">
                <Button
                  onClick={() =>
                    handleStatus(a.id, "Услуга оказана", null)
                  }
                >
                  Завершить (без фото)
                </Button>
                <label className="block text-gray-700 dark:text-gray-300">
                  Фото результата
                  <input
                    type="file"
                    onChange={(e) =>
                      handleStatus(a.id, "Услуга оказана", e.target.files[0])
                    }
                    className="block mt-1"
                  />
                </label>
              </div>
            )}
          </div>
        ))}
      </div>
    </div>
  );
}
