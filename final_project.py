from PIL import Image
import glob
import numpy as np
from sklearn.model_selection import train_test_split


import matplotlib.pyplot as plt

import tensorflow as tf
from tensorflow.keras import utils, layers
from tensorflow.keras.models import Sequential, load_model
from tensorflow.keras.layers import Input, Conv2D, MaxPooling2D, Dense, Flatten, Dropout
from tensorflow.keras.utils import to_categorical
from tensorflow.keras.callbacks import EarlyStopping
from keras.preprocessing.image import ImageDataGenerator


import keras
from keras_preprocessing.image import img_to_array, load_img, array_to_img

import re



images = glob.glob("./images/*.jpg")
class_name = ['food', 'interior', 'exterior']
dic = {"food":0, "interior":1, "exterior":2}

X = []
y = []


for imagename in images:
    image = Image.open(imagename).convert('RGB')
    image = image.resize((300, 300))
    image = np.array(image)
    X.append(image)
    
    label = imagename.split('/')[2].split('.')[0]
    p = re.compile("[^0-9]")
    label="".join(p.findall(label))
    label = dic[label]
    y.append(label)


X = np.array(X)
y = np.array(y)
print(y)


train_images, test_images, train_labels, test_labels = train_test_split(X, y, test_size=0.2, shuffle=True, random_state=44)

train_labels = train_labels[..., tf.newaxis]
test_labels = test_labels[..., tf.newaxis]

print(train_images.shape, train_labels.shape, test_images.shape, test_labels.shape)

##training set 의 각 class 별 Image 수 확인
unique, counts = np.unique(np.reshape(train_labels, (36000,)), axis=-1, return_counts=True)
dict(zip(unique, counts)) ## 골고루 분리된것을 알 수 있음 (Out: {0: 16009, 1: 11990, 2: 8001})

##test set의 각 class 별 Image 수 확인
unique, counts = np.unique(np.reshape(test_labels, (9000,)), axis=-1, return_counts=True)
dict(zip(unique, counts)) ## 골고루 분리된것을 알 수 있음 (Out:  {0: 3991, 1: 3010, 2: 1999})

N_Train = train_images.shape[0]
N_TEST = test_images.shape[0]
print(N_Train) ##36000
print(N_TEST) ##9000

print(train_images.shape)
print(test_images.shape)
print(train_labels.shape)
print(test_labels.shape)

print(test_labels)
##Data 확인 
plt.figure(figsize=(15, 9))
for i in range(15):
    img_idx = np.random.randint(0, 36000)
    plt.subplot(3, 5, i+1)
    plt.xticks([])
    plt.yticks([])
    plt.grid(False)
    plt.imshow(train_images[img_idx])
    plt.xlabel(class_name[train_labels[img_idx][0]])
    



## Hyper-parameter
epochs = 10
batch_size = 3000
n_class = 3

# pixel값을 0-1사이의 범위로 조정

# label을 one-hot encoding
train_labels = keras.utils.to_categorical(train_labels, n_class)
test_labels = keras.utils.to_categorical(test_labels, n_class)

print(test_labels)

## CNN 모델 구성
model = Sequential([
    Input(shape=(300,300,3), name ='input_layer'),
    
    Conv2D(32, kernel_size=3, padding='same', activation='relu', name='conv_layer1'), 
    MaxPooling2D(pool_size=2),
    #Dropout(0.5),
    
    
    Conv2D(64, kernel_size= 3, padding='same', activation='relu', name='conv_layer2'),
    MaxPooling2D(pool_size=2),
    #Dropout(0.5),
    
    Conv2D(128, kernel_size=3, padding='same', activation='relu', name='conv_layer3'),
    MaxPooling2D(pool_size=2),
    #Dropout(0.5),
    
    Flatten(),
    Dense(128, activation='relu'),
    #Dropout(0.5),
    Dense(3, activation='softmax', name='output_layer')
    ])


model.summary()

model.compile(loss='categorical_crossentropy', optimizer='adam', metrics=['accuracy'])
#과적합 방지
early_stopping = EarlyStopping(monitor='val_loss', patience=10)

history = model.fit(train_images, train_labels, epochs=epochs, validation_data=(test_images, test_labels), shuffle=True, callbacks=[early_stopping])


model.save('model-201811527')


loss, acc = model.evaluate(test_images, test_labels)
print("\nLoss: {}, Acc: {}".format(loss, acc))


predictions = model.predict(test_images)

print(predictions)


"""
def plot_image(i, predictions_array, true_label, img):
    predictions_array, ture_label, img = predictions_array[i], true_label[i], img[i]
    plt.grid(False)
    plt.xticks([])
    plt.yticks([])
    
    plt.imshow(img, cmap=plt.cm.binary)
    
    predicted_label = np.argmax(predictions_array)
    if predicted_label == np.argmax(true_label):
        color = 'blue'
    else:
        color = 'red'
        
    plt.xlabel("{} {:2.0f}% ({})".format(class_name[predicted_label], 
                                         100*np.max(predictions_array),
                                         class_name[np.argmax(true_label)]),
                                         color=color)
    
def plot_value_array(i, predictions_array, true_label):
    predictions_array, true_label = predictions_array[i], true_label[i]
    plt.grid(False)
    plt.xticks([])
    plt.yticks([])
    thisplot = plt.bar(range(10), predictions_array, color='#777777')
    plt.ylim([0, 1])
    predicted_label = np.argmax(predictions_array)
    
    thisplot[predicted_label].set_color('red')
    thisplot[np.argmax(true_label)].set_color('blue')
    
    
num_rows = 5
num_cols = 3
num_images = num_rows * num_cols
plt.figure(figsize=(2*2*num_cols, 2*num_rows))
for i in range(num_images):
    plt.subplot(num_rows, 2*num_cols, 2*i+1)
    plot_image(i, predictions, test_labels, test_images)
    plt.subplot(num_rows, 2*num_cols, 2*i+2)
    plot_value_array(i, predictions, test_labels)
plt.show()
"""