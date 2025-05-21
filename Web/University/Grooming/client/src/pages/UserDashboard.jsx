import React, { useContext, useEffect, useState } from "react";
import { AuthContext } from "@/context/AuthContext";
import {
  getAppointments,
  createAppointment,
  deleteAppointment
} from "@/lib/utils/api";
import { Button } from "@/components/ui/button";

export default function UserDashboard() {
  const { user, logout, token } = useContext(AuthContext);
  const [appointments, setAppointments] = useState([]);
  const [name, setName] = useState("");
  const [photo, setPhoto] = useState(null);

  useEffect(() => {
    getAppointments(token).then(setAppointments);
  }, []);

  async function handleNew(e) {
    e.preventDefault();
    const data = new FormData();
    data.append("name", name);
    data.append("photo", photo);
    await createAppointment(token, data);
    setName("");
    setPhoto(null);
    setAppointments(await getAppointments(token));
  }

  async function handleRemove(id) {
    await deleteAppointment(token, id);
    setAppointments(await getAppointments(token));
  }

  return (
    <div className="min-h-screen bg-gray-50 dark:bg-gray-900 py-12 px-4 flex flex-col items-center">
      <div className="w-full max-w-2xl space-y-6">
        <div className="flex justify-between items-center">
          <h1 className="text-2xl font-bold text-gray-900 dark:text-gray-100">
            Привет, {user.fullName}
          </h1>
          <button
            onClick={logout}
            className="text-primary underline hover:text-primary/80"
          >
            Выход
          </button>
        </div>

        <form
          onSubmit={handleNew}
          className="bg-white dark:bg-gray-800 rounded-lg shadow p-6 space-y-4"
        >
          <h2 className="text-xl font-semibold text-gray-800 dark:text-gray-200">
            Создать новую заявку
          </h2>
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              Кличка питомца
            </label>
            <input
              value={name}
              onChange={(e) => setName(e.target.value)}
              className="w-full px-4 py-2 border rounded focus:ring focus:ring-primary/50 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100"
            />
          </div>
          <div>
            <label className="block text-gray-700 dark:text-gray-300 mb-1">
              Фото питомца
            </label>
            <input
              type="file"
              onChange={(e) => setPhoto(e.target.files[0])}
              className="block w-full text-gray-900 dark:text-gray-100"
            />
          </div>
          <Button type="submit">Отправить</Button>
        </form>

        <div className="space-y-4">
          {appointments.map((a) => (
            <div
              key={a.id}
              className="bg-white dark:bg-gray-800 rounded-lg shadow p-4 flex justify-between items-center"
            >
              <div>
                <p className="font-medium text-gray-900 dark:text-gray-100">
                  {a.name}
                </p>
                <p className="text-sm text-gray-600 dark:text-gray-400">
                  {a.status}
                </p>
              </div>
              {a.status === "Новая" && (
                <Button
                  variant="destructive"
                  size="sm"
                  onClick={() => handleRemove(a.id)}
                >
                  Удалить
                </Button>
              )}
            </div>
          ))}
        </div>
      </div>
    </div>
  );
}
