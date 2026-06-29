import requests
from bs4 import BeautifulSoup

url = input("請輸入網址：")

headers = {
    "User-Agent": "Mozilla/5.0"
}

response = requests.get(url, headers=headers)
response.encoding = "utf-8"

html = response.text

soup = BeautifulSoup(html, "html.parser")

# 移除 script、style 這些不需要的內容
for tag in soup(["script", "style"]):
    tag.decompose()

# 取得整頁文字
text = soup.get_text(separator="\n")

# 清理空白行
lines = []
for line in text.splitlines():
    line = line.strip()
    if line:
        lines.append(line)

result = "\n".join(lines)

print(result)