search_text = ","
replace_text = ''
with open("Words to Find.txt", "r") as file:
    data = file.read()
    data = data.replace(search_text,replace_text)
with open("Words to Find.txt", "w") as file:
    file.write(data)