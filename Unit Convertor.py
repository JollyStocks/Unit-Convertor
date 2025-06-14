import tkinter as tk
from tkinter import ttk

unit_convertor = tk.Tk()
unit_convertor.title("Unit Converter")
unit_convertor.geometry("700x410")
unit_convertor.resizable(False, False)

# Theme
unit_convertor.tk.call("source", "C:/Users/Morri/Downloads/Unit Convertor/Azure/azure.tcl")
style = ttk.Style(unit_convertor)
style.theme_use("azure-light")
style.configure("TRadiobutton", background="#f4f4f4", focuscolor="")
style.map("TRadiobutton", background=[("active", "#f4f4f4"), ("selected", "#f4f4f4")])
unit_convertor.configure(bg="#f4f4f4")

length_options = ["Picometer [pm]", "Nanometer [nm]", "Micrometer [μm]", "Millimeters [mm]",
           "Centimeters [cm]", "Meters [m]", "Kilometers [km]"]


length_selected_category = tk.StringVar(value="Length")


# Header
frame_1 = tk.Frame(unit_convertor, bg="#007fff", height=35)
frame_1.grid(row=0, column=0, columnspan=2, sticky="ew")
frame_1.columnconfigure(0, weight=1)
tk.Label(frame_1, text="Unit Convertor", font=("Segoe UI", 20, "bold"),
         bg="#007fff", fg="black").grid(row=0, column=0, pady=4)

# Frames for each category
length_frame = tk.Frame(unit_convertor, bg="#f4f4f4")
mass_frame = tk.Frame(unit_convertor, bg="#f4f4f4")
for frame in (length_frame, mass_frame):
    frame.grid(row=3, column=0, columnspan=2, rowspan=4, padx=190, sticky="w")

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

# Mass widgets (blank dropdowns)
ttk.Label(mass_frame, text="From").grid(row=0, column=0, sticky="w")
ttk.Entry(mass_frame, width=30).grid(row=1, column=0, padx=(0, 10))
ttk.Combobox(mass_frame, values=[], width=20, state="readonly").grid(row=1, column=1)

ttk.Label(mass_frame, text="To").grid(row=8, column=0, sticky="w", pady=(80, 0))
ttk.Entry(mass_frame, width=30).grid(row=9, column=0, padx=(0, 10))
ttk.Combobox(mass_frame, values=[], width=20, state="readonly").grid(row=9, column=1)

# Radiobuttons
def raise_frame(frame):
    frame.tkraise()

ttk.Radiobutton(unit_convertor, text="Length", variable=length_selected_category,
                value="Length", command=lambda: raise_frame(length_frame)).grid(
    row=1, column=0, padx=10, pady=10, sticky="w")

ttk.Radiobutton(unit_convertor, text="Mass", variable=length_selected_category,
                value="Mass", command=lambda: raise_frame(mass_frame)).grid(
    row=2, column=0, padx=10, pady=10, sticky="w")

# Length conversion logic (unchanged)
def length_conversion(event=None):
    conversion_factors = {
        "Picometer [pm]": 1e-12, "Nanometer [nm]": 1e-9, "Micrometer [μm]": 1e-6,
        "Millimeters [mm]": 1e-3, "Centimeters [cm]": 1e-2, "Meters [m]": 1, "Kilometers [km]": 1e3
    }

    if event.widget == dispbx_input or event.widget == to_combo:
        dispbx_input_str = dispbx_input.get()
        if dispbx_input_str == "":
            dispbx_output.delete(0, tk.END)
            return
        from_unit = from_combo.get()
        num_input = dispbx_input.get()
        str_to_int = int(num_input)
        to_unit = to_combo.get()
        value_in_meters = str_to_int * conversion_factors[from_unit]
        converted_value = value_in_meters / conversion_factors[to_unit]
        dispbx_output.delete(0, tk.END)
        dispbx_output.insert(tk.END, converted_value)

    elif event.widget == dispbx_output or event.widget == from_combo:
        dispbx_output_str = dispbx_output.get()
        if dispbx_output_str == "":
            dispbx_input.delete(0, tk.END)
            return
        to_unit = to_combo.get()
        num_output_1 = dispbx_output.get()
        str_to_int_1 = int(num_output_1)
        from_unit = from_combo.get()
        value_in_meters_1 = str_to_int_1 * conversion_factors[to_unit]
        converted_value_1 = value_in_meters_1 / conversion_factors[from_unit]
        dispbx_input.delete(0, tk.END)
        dispbx_input.insert(tk.END, converted_value_1)

# Bindings
def setup_bindings():
    dispbx_input.bind("<KeyRelease>", length_conversion)
    dispbx_output.bind("<KeyRelease>", length_conversion)
    from_combo.bind("<<ComboboxSelected>>", length_conversion)
    to_combo.bind("<<ComboboxSelected>>", length_conversion)

setup_bindings()
raise_frame(length_frame)
unit_convertor.mainloop()
