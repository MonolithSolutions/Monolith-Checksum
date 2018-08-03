# Monolith-Checksum
Monolith Checksum is a simple windows GUI file checksum for SHA1/SHA256/MD5 algorithms. 
It supports text string comparison to compare checksums and supports multiple file checking.
With this program you can:
- Open a file and view it's SHA1/SHA256/MD5 checksum value
- Compare the opened files checksum value to the authentic checksum value issued by the website you are downloading the file from
- Open an entire folder and get the checksum values of all files in the folder (exports to a CSV in the same folder)

Feature Enhancements (Pending):
- Make multiple file hashing a more user freindly procedure
- Implement windows shell so can simply right click a file and hit checksum then paste in the authentic key and have it compare more automatically
- Make the help file look pretty instead of like junk
- Make the GUI match windows 10

Reported Bugs:
- None at the moment see Issues section

How to use for single files:
1. Press open and select a file you just downloaded
2. Paste the checksum of the file you just downloaded into the corresponding text box
3. Press the check button
4. If the hashed value of the file you opened matches what you pasted into the text box, you will get a green checkmark. The file is valid
5. If you did not paste a value into the textbox you will get a yellow questionmark
6. If the hashed valeu of the file you opened does not match the pasted value, you will get a red X. The file is not valid.

How to use for multiple files:
1. Select file>open folder
2. Choose a folder containing all the files you wish to hash
3. Open it and click yes to the prompt
4. A CSV file will be created in the directory you chose. It will contain a list of all the files in the directory and what their 
respective checksum values are.
