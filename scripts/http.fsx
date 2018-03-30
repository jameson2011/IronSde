
open System

let downloadFileAsync (targetFile: string) (url: string) =
    async {
        use client = new System.Net.WebClient()

        client.DownloadFile(url, targetFile)
    
        return targetFile
    }
