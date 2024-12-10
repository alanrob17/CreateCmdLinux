# Create Command Linux

Create a command file for a directory listing on a Linux Mint 22 system.

This code generates a two-column directory listing of a directory's contents so that a user can rename the files. It creates an executable bash script.

## An example of alan.sh

```bash
#!/bin/bash
mv "01 - (I'm) Stranded (Original Mix).flac"       "01 - (I'm) Stranded (Original Mix).flac"
mv "02 - One Way Street (Original Mix).flac"       "02 - One Way Street (Original Mix).flac"
mv "03 - Wild About You (Original Mix).flac"       "03 - Wild About You (Original Mix).flac"
...
```

I can use this to rename the flac files.

```bash
#!/bin/bash
mv "01 - (I'm) Stranded (Original Mix).flac"       "01 - (I'm) Stranded.flac"
mv "02 - One Way Street (Original Mix).flac"       "02 - One Way Street.flac"
mv "03 - Wild About You (Original Mix).flac"       "03 - Wild About You).flac"
...
```
