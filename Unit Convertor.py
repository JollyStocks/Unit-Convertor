import tkinter as tk
from tkinter import ttk

def length_conversion(event=None):
    conversion_factors = {
        "Picometer [pm]": 1e-12, "Nanometer [nm]": 1e-9, "Micrometer [μm]": 1e-6,
        "Millimeters [mm]": 1e-3, "Centimeters [cm]": 1e-2,
        "Meters [m]": 1, "Kilometers [km]": 1e3
    }

    try:
        if event.widget == dispbx_input or event.widget == to_combo:
            val = dispbx_input.get()
            if val == "":
                dispbx_output.delete(0, tk.END)
                return
            from_unit = from_combo.get()
            to_unit = to_combo.get()
            result = float(val) * conversion_factors[from_unit] / conversion_factors[to_unit]
            dispbx_output.delete(0, tk.END)
            dispbx_output.insert(0, round(result, 5))

        elif event.widget == dispbx_output or event.widget == from_combo:
            val = dispbx_output.get()
            if val == "":
                dispbx_input.delete(0, tk.END)
                return
            from_unit = from_combo.get()
            to_unit = to_combo.get()
            result = float(val) * conversion_factors[to_unit] / conversion_factors[from_unit]
            dispbx_input.delete(0, tk.END)
            dispbx_input.insert(0, round(result, 5))
    except Exception:
        pass

# Set up main window
window = tk.Tk()
window.title("Unit Converter")
window.geometry("700x410")
window.resizable(False, False)
window.configure(bg="#f4f4f4")

length_options = ["Picometer [pm]", "Nanometer [nm]", "Micrometer [μm]",
                  "Millimeters [mm]", "Centimeters [cm]", "Meters [m]",
                  "Kilometers [km]"]

length_selected_category = tk.StringVar(value="Length")

# Header
frame_1 = tk.Frame(window, bg="#007fff", height=35)
frame_1.grid(row=0, column=0, columnspan=2, sticky="ew")
frame_1.columnconfigure(0, weight=1)
header = tk.Label(frame_1, text="Unit Convertor", font=("Segoe UI", 20, "bold"),
                  bg="#007fff", fg="black")
header.grid(row=0, column=0, pady=4)

# Length converter frame
length_frame = tk.Frame(window, bg="#f4f4f4")
length_frame.grid(row=3, column=0, columnspan=2, rowspan=4, padx=190, sticky="w")

# Length widgets
from_lbl = ttk.Label(length_frame, text="From")
from_lbl.grid(row=0, column=0, sticky="w")

dispbx_input = ttk.Entry(length_frame, width=30)
dispbx_input.grid(row=1, column=0, padx=(0, 10))

from_combo = ttk.Combobox(length_frame, values=length_options, width=20, state="readonly")
from_combo.set("Select a unit")
from_combo.grid(row=1, column=1)

to_lbl = ttk.Label(length_frame, text="To")
to_lbl.grid(row=8, column=0, sticky="w", pady=(80, 0))

dispbx_output = ttk.Entry(length_frame, width=30)
dispbx_output.grid(row=9, column=0, padx=(0, 10))

to_combo = ttk.Combobox(length_frame, values=length_options, width=20, state="readonly")
to_combo.set("Select a unit")
to_combo.grid(row=9, column=1)

# Radio button
length_radiobutton = ttk.Radiobutton(window, text="Length",
                                     variable=length_selected_category, value="Length")
length_radiobutton.grid(row=1, column=0, padx=10, pady=10, sticky="w")

# Bindings
dispbx_input.bind("<KeyRelease>", length_conversion)
dispbx_output.bind("<KeyRelease>", length_conversion)
from_combo.bind("<<ComboboxSelected>>", length_conversion)
to_combo.bind("<<ComboboxSelected>>", length_conversion)


window.mainloop()
